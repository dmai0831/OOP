using System;
using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void Retrieve()
        {
            // Arrange
            OrderRepository orderRepository = new OrderRepository();
            var expected = new Order()
            {
                OrderDate = new DateTimeOffset(2019, 2, 28, 10, 18, 0, TimeSpan.FromHours(+3))
            };

            //Act
            var actual = orderRepository.Retrieve(10);

            //Assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
        [TestMethod]
        public void RetrieveOrderDisplayTest()
        {
            //Arrange
            var orderRepository = new OrderRepository();
            var expected = new OrderDisplay()
            {
                FirstName = "Duc",
                LastName = "Mai",
                OrderDate = new DateTimeOffset(2019, 2, 28, 23, 0, 0, TimeSpan.FromHours(+3)),
                ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Quincy",
                    State = "MA",
                    Country = "United States",
                    PostalCode = "02169"
                },
                orderDisplayItemList = new List<OrderDisplayItem>()
                {
                    new OrderDisplayItem()
                    {
                        OrderQuantity=2,
                        ProductName="Sunflowers",
                        PurchasePrice=15.9M
                    },
                    new OrderDisplayItem()
                    {
                        OrderQuantity=1,
                        ProductName="Rake",
                        PurchasePrice=6M
                    }
                }
            };

            //Act
            var actual = orderRepository.RetrieveOrderDisplay(10);

            //Assert
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
            Assert.AreEqual(expected.ShippingAddress.AddressType, actual.ShippingAddress.AddressType);
            Assert.AreEqual(expected.ShippingAddress.StreetLine1, actual.ShippingAddress.StreetLine1);
            Assert.AreEqual(expected.ShippingAddress.StreetLine2, actual.ShippingAddress.StreetLine2);
            Assert.AreEqual(expected.ShippingAddress.City, actual.ShippingAddress.City);
            Assert.AreEqual(expected.ShippingAddress.State, actual.ShippingAddress.State);
            Assert.AreEqual(expected.ShippingAddress.Country, actual.ShippingAddress.Country);
            Assert.AreEqual(expected.ShippingAddress.PostalCode, actual.ShippingAddress.PostalCode);
            for(int i=0; i<1; i++)
            {
                Assert.AreEqual(expected.orderDisplayItemList[i].ProductName, actual.orderDisplayItemList[i].ProductName);
                Assert.AreEqual(expected.orderDisplayItemList[i].OrderQuantity, actual.orderDisplayItemList[i].OrderQuantity);
                Assert.AreEqual(expected.orderDisplayItemList[i].PurchasePrice, actual.orderDisplayItemList[i].PurchasePrice);
            }
        }
    }
}
