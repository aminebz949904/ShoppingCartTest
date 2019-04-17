using FruitShop.Interfaces;
using FruitShop.Services;
using Moq;
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

            var buyOneGetOneFreeMock = new Mock<IOffer>();
            var threeForPriceOfTwo = new Mock<IOffer>();

            buyOneGetOneFreeMock.Setup(a => a.GetPrice(It.IsAny<int>(), 0.6M)).Returns(10M);
            threeForPriceOfTwo.Setup(a => a.GetPrice(It.IsAny<int>(), 0.25M)).Returns(40M);

            var productList = new List<FruitShop.Products.Fruit >
             {
                 new FruitShop.Products.Fruit(buyOneGetOneFreeMock.Object, "Apple", 0.60M),
                 new FruitShop.Products.Fruit(threeForPriceOfTwo.Object, "Orange", 0.25M)
             };

            var shoppingCart = new ShoppingCartService(productList, scannedList);

            //Act
            var totalCost = shoppingCart.GetTotal();

            //Assert
            Assert.AreEqual(50M, totalCost);
            buyOneGetOneFreeMock.Verify(a => a.GetPrice(It.IsAny<int>(), 0.6M),Times.Once);
            threeForPriceOfTwo.Verify(a => a.GetPrice(It.IsAny<int>(), 0.25M), Times.Once);
        }
    }
}
