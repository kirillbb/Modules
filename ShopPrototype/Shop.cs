using System;
using System.Collections.Generic;
using System.Threading;

namespace Module2HW2
{
    public static partial class ProductsList
    {
        public static void Run()
        {
            ShowProductList();

            AddProductsToBasket();

            PlaceAnOrder();
        }

        private static void ShowProductList()
        {
            Console.WriteLine("Product list:\n");
            foreach (var product in Products)
            {
                Console.WriteLine($"{product.Index} ___ {product.Name} - {product.Price}$");
            }
        }

        private static void AddProductsToBasket()
        {
            Console.WriteLine("\nHow many items would you like to purchase?");
            var input = Console.ReadLine();
            int count;

            while (!int.TryParse(input, out count))
            {
                Console.WriteLine("Incorrect input, use digits, try again!");
                input = Console.ReadLine();
            }

            Console.Write($"\nAdding {count} random items to shopping basket");

            int n = 0;
            while (n < 6)
            {
                Console.Write(" .");
                Thread.Sleep(200);
                n++;
            }

            Console.Write("\n");

            Random random = new ();

            for (int i = 0; i < count; i++)
            {
                int item = random.Next(0, Products.Count);
                Basket.BasketList.Add(Products[item]);
                Console.WriteLine($"{Products[item].Index} ___ " +
                    $"{Products[item].Name} - " +
                    $"{Products[item].Price}$");

                Thread.Sleep(500);
            }
        }

        private static void PlaceAnOrder()
        {
            Console.WriteLine("Press Enter-button to place an order!");
            Console.ReadLine();

            Console.Clear();

            Order order = new ();

            Console.WriteLine($"Congratulations, your order #{order.OrderNumber} has been placed!");
            Console.WriteLine("Your order has:");

            for (int i = 0; i < Basket.BasketList.Count; i++)
            {
                Order.OrderList.Add(Basket.BasketList[i]);
                Console.WriteLine($"{Order.OrderList[i].Index} ___ " +
                    $"{Order.OrderList[i].Name} - " +
                    $"{Order.OrderList[i].Price}$");

                Thread.Sleep(500);
            }

            Order.TotalPrice(Order.OrderList);
        }
    }
}