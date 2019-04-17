using System;
using System.Collections.Generic;
using System.Text;

namespace FruitShop.Products
{
    public class Fruit
    {
        public Fruit(string name, decimal unitPrice)
        {
            Name = name;
            UnitPrice = unitPrice;
        }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }

        public decimal Cost()
        {
            return Quantity * UnitPrice;
        }
    }
}
