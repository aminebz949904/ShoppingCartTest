using FruitShop.Offers;
using NUnit.Framework;

namespace Fruit.Shop.Test.Unit
{
    [TestFixture]
    public class ThreeForPriceOfTwoTests
    {
        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 0.25)]
        [TestCase(2, 0.50)]
        [TestCase(3, 0.5)]
        [TestCase(4, 0.75)]
        [TestCase(5, 1)]
        [TestCase(6, 1)]
        [TestCase(7, 1.25)]
        [TestCase(8, 1.50)]
        [TestCase(9, 1.50)]
        [TestCase(10, 1.75)]
        public void GetPricetest(int quantity, decimal expectedPrice)
        {
            //Arrange
            var threeForPriceOfTwo = new ThreeForPriceOfTwo();

            //Act
            var res = threeForPriceOfTwo.GetPrice(quantity, 0.25M);

            //Assert
            Assert.AreEqual(expectedPrice, res);

        }
    }
}
