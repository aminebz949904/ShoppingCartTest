using FruitShop.Services;
using NUnit.Framework;
using System.Collections.Generic;

namespace Fruit.Shop.Test.Unit
{
    [TestFixture]
    public class ShoppingCartTests
    {
        [Test]
        public void GetTotal_Tests()
        {
            //Arrange
            var scannedList = new List<string> { "apple", "apple", "orange", "apple" };

            var productList = new List<FruitShop.Products.Fruit >
             {
                 new FruitShop.Products.Fruit("Apple", 0.60M),
                 new FruitShop.Products.Fruit("Orange", 0.25M)
             };

            var shoppingCart = new ShoppingCartService(productList, scannedList);

            //Act
            var totalCost = shoppingCart.GetTotal();

            //Assert
            Assert.AreEqual(2.05M, totalCost);

        }
    }
}
