using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string serialNumber = parts[0];
                string itemName = parts[1];
                int itemQuantity = int.Parse(parts[2]);
                decimal itemPrice = decimal.Parse(parts[3]);

                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNumber, item, itemQuantity);
                boxes.Add(box);
            }

           
            List<Box> sortedBoxes = boxes.OrderByDescending(b => b.PriceForBox).ToList();

            foreach (Box box in sortedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:F2}");
            }
        }
    }

    class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Box
    {
        public Box(string serialNumber, Item item, int itemQuantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
        }

        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }

        public decimal PriceForBox => ItemQuantity * Item.Price;
    }
}
