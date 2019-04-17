using FruitShop.Products;
using System;
using System.Collections.Generic;
using System.Linq;


namespace FruitShop.Services
{
    public class ShoppingCartService
    {
        private List<Fruit> _productList;
        private List<String> _scannedList;

        public ShoppingCartService(List<Fruit> productList, List<String> scannedList)
        {
            _productList = productList;
            _scannedList = scannedList;
        }


        public decimal GetTotal()
        {
            var totalCart = 0M;
            _productList.ForEach(f => 
            {
               f.Quantity= _scannedList.Count(p => p.ToUpper() == f.Name.ToUpper());
                totalCart += f.Cost();
            });

            return totalCart;
        }
    }
}
