using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveExiting()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "dmai0831@gmail.com",
                FirstName = "Duc",
                LastName = "Mai"
            };

            //Act
            var actual = customerRepository.Retrieve(1);

            //Assert

            //Eventhought 2 objects have the same values for the properties.
            //However, those 2 instances are not seem to equal because they are not references the same object.
            //Assert.AreEqual(expected, actual);

            //We need to compare each individual property
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }
    }
}
