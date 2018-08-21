using System;
using System.Collections.Generic;
using System.Reflection;

public class VipStrategyFactory
{
    private static VipStrategyFactory _instance;

    public static VipStrategyFactory Instance
    {
        get
        {
            if (_instance == null)
                _instance = new VipStrategyFactory();
            return _instance;
        }
    }

    //改写获取方法，利用特性筛选
    public IVipStrategy GetVipStrategy(Consumer consumer)
    {
        var totalConsume = consumer.TotalConsume;
        var types = GetVipStrategy();
        foreach (var type in types)
        {
            var att = GetAttribute(type);
            if (att == null) continue;
            if ((att.Min <= totalConsume) && (totalConsume < att.Max))
                return (IVipStrategy) Activator.CreateInstance(type);
        }
        return new PublicVipStrategy();
    }

    private static PriceAttribute GetAttribute(Type t)
    {
        var atts = t.GetCustomAttributes(typeof(PriceAttribute), true);
        if ((atts == null) || (atts.Length <= 0)) return null;
        foreach (PriceAttribute att in atts)
            return att;
        return null;
    }

    private Type[] GetVipStrategy()
    {
        var temp = Assembly.GetCallingAssembly().GetTypes();
        var typeFullName = typeof(IVipStrategy);
        var list = new List<Type>();
        foreach (var type in temp)
        {
            var baseType = type.BaseType;
            while (baseType != null)
            {
                if (baseType == typeFullName)
                {
                    list.Add(type);
                    break;
                }
                baseType = baseType.BaseType;
            }
        }
        return list.ToArray();
    }
}