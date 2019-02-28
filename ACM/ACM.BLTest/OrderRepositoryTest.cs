using System;
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
    }
}
