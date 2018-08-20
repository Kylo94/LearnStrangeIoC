namespace Assets.Demo01.Strategy
{
    public class Vip : CalPrice
    {
        public float calPrice(float price)
        {
            return price * 0.9f;
        }
    }
}