using FruitShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FruitShop.Offers
{
    public class ThreeForPriceOfTwo : IOffer
    {
        public decimal GetPrice(int number, decimal unitPrice)
        {
            var price = 0m;

            var threeNumber = (decimal)number / 3;

            var offer = Math.Floor(threeNumber);

            var extra = number - (offer *3);

            price = (unitPrice * 2 * offer + extra * unitPrice);

            return price;
        }
    }
}
