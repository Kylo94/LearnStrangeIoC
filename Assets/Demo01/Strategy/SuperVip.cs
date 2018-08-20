namespace Assets.Demo01.Strategy
{
    [PriceRegion(min:2000, max: 3000)]
    public class SuperVip : CalPrice
    {
        public float calPrice(float price)
        {
            return price * 0.8f;
        }
    }
}