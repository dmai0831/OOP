using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void Retrieve()
        {
            //Arrange
            var product = new ProductRepository();

            var expected = new Product()
            {
                ProductName = "Sunflowers",
                ProductDescription = "Assorted Size",
                CurrentPrice=15M
            };

            //Act
            var actual = product.Retrieve(2);

            //Assert
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);

        }
    }
}
