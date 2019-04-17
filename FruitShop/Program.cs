using FruitShop.Offers;
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
            var scannedList = new List<string>{ "apple", "apple", "orange" , "apple", "orange" , "orange" };

            var buyOneGetOneFree = new BuyOneGetOneFree();
            var threeForPriceOfTwo = new ThreeForPriceOfTwo();

            var productList = new List<Fruit>
             {
                 new Fruit(buyOneGetOneFree, "Apple", 0.60M),
                 new Fruit(threeForPriceOfTwo, "Orange", 0.25M)
             };

            var shoppingCart = new ShoppingCartService(productList, scannedList);

            Console.WriteLine($"Total Cart: £{shoppingCart.GetTotal()}");
            Console.ReadLine();
        }
    }
}
