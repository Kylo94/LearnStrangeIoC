using System;

[AttributeUsage(AttributeTargets.Class)] //限定由于修饰类
public class PriceAttribute : Attribute
{
    public PriceAttribute(int min = -1, int max = 999999)
    {
        Max = max;
        Min = min;
    }

    public float Max { private set; get; }
    public float Min { private set; get; }
}