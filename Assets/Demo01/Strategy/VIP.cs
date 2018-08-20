namespace Assets.Demo01.Strategy
{
    [PriceRegion(max: 2000)]
    public class Vip : CalPrice
    {
        public float calPrice(float price)
        {
            return price * 0.9f;
        }
    }
}