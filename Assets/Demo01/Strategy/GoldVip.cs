namespace Assets.Demo01.Strategy
{
    [PriceRegion(max: 3000)]
    public class GoldVip : CalPrice
    {
        public float calPrice(float price)
        {
            return price * 0.7f;
        }
    }
}