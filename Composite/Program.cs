using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {

            var root = new CompositeGift("Box", 0);

            root.AddGift(new Gift("Phone", 100));
            root.AddGift(new Gift("Toy", 10));
            root.AddGift(new Gift("Bicycle", 200));


            var childBox = new CompositeGift("ChildBox", 0);
            childBox.AddGift(new Gift("Game", 3000));
            childBox.AddGift(new Gift("mini car", 9000));

            var specialBox = new CompositeGift("MiniBox", 0);
            specialBox.AddGift(new Gift("Computer", 1000));
            specialBox.AddGift(new Gift("TV", 1000));
            specialBox.AddGift(new Gift("Play Station", 10000));

            childBox.AddGift(specialBox);
            root.AddGift(childBox);

            root.AddGift(new Gift("Ball", 909090));

            Console.WriteLine($"Nessa caixa de brinquedos há um total de: {root.CountGift()}");
            Console.WriteLine($"O valor total gasto nesses presentes foi: {root.TotalPrice()}");
        }
    }
}
