[Price(0,1000)]
public class PublicVipStrategy : IVipStrategy
{
    public override float GetExtenditure(float price)
    {
        return price;
    }
}