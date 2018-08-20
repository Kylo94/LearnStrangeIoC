namespace Assets.Demo01.Strategy
{
    public class Player
    {
        private float amount;
        private CalPrice calPrice = new Orgnic();
        private float totalAmount;

        public void buy(float amount)
        {
            this.amount = amount;
            totalAmount += amount;
            calPrice = CalPriceFactory.getInstance().createCalPrice(this);
        }

        public float CalLastAmount()
        {
            return calPrice.calPrice(amount);
        }

        public float getTotalAmount()
        {
            return totalAmount;
        }
    }
}