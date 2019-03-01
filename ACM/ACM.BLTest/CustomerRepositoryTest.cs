using System;
using System.Collections.Generic;
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
        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "dmai0831@gmail.com",
                FirstName = "Duc",
                LastName="Mai",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType=1,
                        StreetLine1="Bag End",
                        StreetLine2="Bagshot row",
                        City="Quincy",
                        State="MA",
                        Country="United States",
                        PostalCode="02169"
                    },
                    new Address()
                    {
                        AddressType=2,
                        StreetLine1="Green Dragon",
                        City="Dorchester",
                        State="MA",
                        Country="United States",
                        PostalCode="02124"
                    }
                }


            };

            //Act
            var actual = customerRepository.Retrieve(1);
            //Assert

            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            for(int i=0; i<1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }
    }
}
