using Composite.Interfaces;
using System.Collections.Generic;

namespace Composite
{
    public class CompositeGift : GiftBase, IGiftOperations
    {
        private IList<GiftBase> _gifts;

        public CompositeGift(string name, decimal price)
            : base(name, price)
        {
            _gifts = new List<GiftBase>();
        }

        public void AddGift(GiftBase gift)
        {
            _gifts.Add(gift);
        }

        public void RemoveGift(GiftBase gift)
        {
            _gifts.Remove(gift);
        }
        public override int CountGift()
        {
            var total = 0;

            foreach (var gift in _gifts)
            {
                total += gift.CountGift();
            }

            return total;
        }

        public override decimal TotalPrice()
        {
            decimal totalPrice = 0;
            
            foreach (var gift in _gifts)
            {
                totalPrice += gift.TotalPrice();
            }

            return totalPrice;
        }

        public override void Display(int depth)
        {
            foreach (var gift in _gifts)
            {
                gift.Display(depth + 2);
            }
        }
    }
}
