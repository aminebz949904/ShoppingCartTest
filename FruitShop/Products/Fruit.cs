using FruitShop.Interfaces;

namespace FruitShop.Products
{
    public class Fruit
    {
        private readonly IOffer _offer;
        public Fruit(IOffer offer, string name, decimal unitPrice)
        {
            Name = name;
            UnitPrice = unitPrice;
            _offer = offer;
        }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }

        public decimal Cost()
        {
           return _offer.GetPrice(Quantity, UnitPrice);
        }
    }
}
