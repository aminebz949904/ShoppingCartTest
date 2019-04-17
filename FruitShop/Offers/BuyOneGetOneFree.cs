using FruitShop.Interfaces;
using System;


namespace FruitShop.Offers
{
    public class BuyOneGetOneFree : IOffer
    {
        public decimal GetPrice(int number, decimal unitPrice)
        {
            var price = 0m;

            var half = (decimal)number / 2;

            var offer = Math.Floor(half);

            var extra = half - offer;

            price = (unitPrice * (offer + (extra > 0 ? 1 : 0)));

            return price;
        }
    }
}
