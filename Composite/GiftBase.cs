namespace Composite
{
    public abstract class GiftBase
    {
        protected GiftBase(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        protected string Name { get; private set; }
        protected decimal Price { get; private set; }

        public abstract decimal TotalPrice();
        public abstract void RemoveGift();
        public abstract void AddGift();
        public abstract int CountGift();
    }
}
