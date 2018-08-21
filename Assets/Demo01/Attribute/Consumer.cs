using UnityEngine;

public class Consumer
{
    private float _price;
    public float TotalConsume { private set; get;  }
    private IVipStrategy _vipStrategy;

    public Consumer()
    {
        _vipStrategy = new PublicVipStrategy();
    }

    public void Buy(int price)
    {
        _price = GetConsume(price);
        Debug.Log("消费了 ： " + _price);
        TotalConsume += _price;
    }

    private float GetConsume(int price)
    {
        _vipStrategy = VipStrategyFactory.Instance.GetVipStrategy(this);
        return _vipStrategy.GetExtenditure(price);
    }
}