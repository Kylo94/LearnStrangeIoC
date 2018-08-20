using UnityEngine;

namespace Assets.Demo01.Strategy
{
    public class Main : MonoBehaviour
    {
        void Start()
        {
            Player p = new Player();
            CalPriceFactory.getInstance();
            //p.buy(1000);
            //Debug.Log("Pay : " + p.CalLastAmount());
            //p.buy(1000);
            //Debug.Log("Pay : " + p.CalLastAmount());
            //p.buy(1000);
            //Debug.Log("Pay : " + p.CalLastAmount());
            //p.buy(1000);
            //Debug.Log("Pay : " + p.CalLastAmount());
        }
    }
}