
[Price(1000,2000)]
public class JuniorVipStrategy : IVipStrategy
{
    public override float GetExtenditure(float price)
    {
        return price * 0.9f;
    }
}