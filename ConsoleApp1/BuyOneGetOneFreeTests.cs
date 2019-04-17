using FruitShop.Offers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fruit.Shop.Test.Unit
{
    [TestFixture]
    public class BuyOneGetOneFreeTests
    {
        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 0.6)]
        [TestCase(2, 0.6)]
        [TestCase(3, 1.2)]
        [TestCase(4, 1.2)]
        [TestCase(5, 1.8)]
        [TestCase(10, 3)]
        public void GetPricetest(int quantity,decimal expectedPrice)
        {
            //Arrange
            var buyOneGetOneFree = new BuyOneGetOneFree();

            //Act
            var res = buyOneGetOneFree.GetPrice(quantity, 0.6M);

            //Assert
            Assert.AreEqual(expectedPrice, res);


        }
    }
}