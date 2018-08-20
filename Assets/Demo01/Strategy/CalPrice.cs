using System;

namespace Assets.Demo01.Strategy
{
    [AttributeUsage(AttributeTargets.Class)]
    public class PriceRegionAttribute : Attribute
    {
        private int min, max;

        public PriceRegionAttribute(int min = -1, int max = -1)
        {
            this.min = min;
            this.max = max;
        }
        public int Min { get { return min; } }
        public int Max { get { return max; } }
    }

    public interface CalPrice
    {
        float calPrice(float origicPrice);
    }
}