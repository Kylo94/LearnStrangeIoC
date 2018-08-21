[Price(2000, 3000)]
public class SeniorVipStrategy : IVipStrategy
{
    public override float GetExtenditure(float price)
    {
        return price*0.8f;
    }
}