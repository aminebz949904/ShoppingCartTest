using FruitShop.Products;
using FruitShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //var scannedList = args.OfType<string>().ToList();
            var scannedList = new List<string>{ "apple", "apple", "orange" , "apple"};

            var productList = new List<Fruit>
             {
                 new Fruit("Apple", 0.60M),
                 new Fruit("Orange", 0.25M)
             };

            var shoppingCart = new ShoppingCartService(productList, scannedList);

            Console.WriteLine($"Total Cart: £{shoppingCart.GetTotal()}");
            Console.ReadLine();
        }
    }
}
