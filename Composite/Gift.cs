namespace Composite
{
    public class Gift : GiftBase
    {
        public Gift(string name, decimal price)
            : base(name, price)
        {

        }

        public override int CountGift()
        {
            return 1;
        }

        public override decimal TotalPrice()
        {
            return this.Price;
        }
    }
}
