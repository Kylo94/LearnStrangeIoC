namespace Assets.Demo01.Strategy
{
    public class Player
    {
        private CalPrice calPrice = new Orgnic();
        private float totalAmount = 0f;
        private float amount = 0f;

        public void buy(float amount)
        {
            this.amount = amount;
            totalAmount += amount;
            if (totalAmount >= 3000)
                calPrice = new GoldVip();
            else if (totalAmount >= 2000)
                calPrice = new SuperVip();
            else if (totalAmount >= 1000)
                calPrice = new Vip();
        }

        public float CalLastAmount()
        {
            return calPrice.calPrice(amount);
        }
    }
}