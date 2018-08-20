namespace Assets.Demo01.Strategy
{
    public class GoldVip : CalPrice
    {
        public float calPrice(float price)
        {
            return price * 0.7f;
        }
    }
}