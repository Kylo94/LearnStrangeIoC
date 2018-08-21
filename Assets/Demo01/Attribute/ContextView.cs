using UnityEngine;

namespace Assets.Demo01.Strategy
{
    public class ContextView : MonoBehaviour
    {
        public void Main()
        {
            var consumer = new Consumer();
            consumer.Buy(1000);
            consumer.Buy(2000);
            consumer.Buy(2800);
            consumer.Buy(3000);
        }
    }
}