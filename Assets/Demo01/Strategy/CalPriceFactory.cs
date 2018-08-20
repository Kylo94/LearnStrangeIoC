using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace Assets.Demo01.Strategy
{
    internal class CalPriceFactory
    {
        private const string CAL_PRICE_PACKAGE = "com.example.stragedemo"; //这里是一个常量，表示我们扫描策略的包

        private List<Type> calPriceList;

        public static CalPriceFactory getInstance()
        {
            return CalPriceFactoryInstance.Instance;
        }

        private static class CalPriceFactoryInstance
        {
            private static CalPriceFactory instance;

            public static CalPriceFactory Instance
            {
                get
                {
                    if (instance == null)
                        instance = new CalPriceFactory();
                    return instance;
                }
            }
        }

        private CalPriceFactory()
        {
            Init();
        }

        private void Init()
        {
            calPriceList = new List<Type>();
            Type[] types = getResources();
            Type calPriceClazz = null;
            for (int i = 0; i < types.Length; i++)
            {
                Type t = types[i];
                Debug.Log(t);
            }
        }

        private Type[] getResources()
        {
            return Assembly.Load("Assets.Demo01.Strategy").GetTypes();                               
        }

        public CalPrice createCalPrice(Player player)
        {
            //在策略列表查找策略
            foreach (var clazz in calPriceList)
            {
                var validRegion = handleAnnotation(clazz); //获取该策略的注解
                //判断金额是否在注解的区间
                if ((player.getTotalAmount() > validRegion.Min) && (player.getTotalAmount() < validRegion.Max))
                    return (CalPrice) Activator.CreateInstance(clazz);
            }
            return null;
        }

        private PriceRegionAttribute handleAnnotation(Type t)
        {
            var something = t.GetCustomAttributes(typeof(PriceRegionAttribute), true);
            foreach (PriceRegionAttribute each in something)
                return each;
            return null;
        }
    }
}