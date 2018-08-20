namespace Assets.Demo01.Strategy
{
    public class SuperVip : CalPrice
    {
        public float calPrice(float price)
        {
            return price * 0.8f;
        }
    }
}