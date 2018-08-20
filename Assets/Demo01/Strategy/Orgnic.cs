namespace Assets.Demo01.Strategy
{
    [PriceRegion(max:1000)]
    public class Orgnic:CalPrice
    {
        public float calPrice(float origicPrice)
        {
            return origicPrice;
        }
    }
}