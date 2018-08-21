[Price(3000)]
public class GoldVipStrategy : IVipStrategy
{
    public override float GetExtenditure(float price)
    {
        return 0.65f*price;
    }
}