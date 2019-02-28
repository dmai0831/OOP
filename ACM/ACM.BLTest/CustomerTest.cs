using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        #region Test FullName property
        /// <summary>
        /// Create FullName valid test
        /// </summary>
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange
            // Prepare anything we need in this block.
            // Create new instance Customer class and assign to customer object variable.
            Customer customer = new Customer();
            customer.FirstName = "Duc";
            customer.LastName = "Mai";

            string expected = "Mai, Duc";

            // Act
            //test FullName properties
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Create FullName invalid test. FirstName is empty
        /// </summary>
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            Customer customer = new Customer();
            customer.LastName = "Mai";
            
            string expected = "Mai";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Create FullName invalid test. LastName is empty
        /// </summary>
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            Customer customer = new Customer();
            customer.FirstName = "Duc";

            string expected = "Duc";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        #endregion
        [TestMethod]
        public void StaticTest()
        {
            // Arrange
            var c1 = new Customer();
            c1.FirstName = "Duc";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Emma";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Bella";
            Customer.InstanceCount += 1;

            // Act

            // Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }
        #region Test Validate function
        [TestMethod]
        public void ValidateTestValid()
        {
            //Arrange
            var customer = new Customer();
            customer.LastName = "Mai";
            customer.EmailAddress = "dmai0831@gmail.com";

            var expected = true;
            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateMissingLastName()
        {
            //Arrange
            var customer = new Customer();
            //customer.FirstName = "Duc";
            customer.EmailAddress = "dmai0831@gmail.com";

            var expected = false;
            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateMissingEmailAddress()
        {
            //Arrange
            var customer = new Customer();
            customer.FirstName = "Duc";
            //customer.EmailAddress = "dmai0831@gmail.com";

            var expected = false;
            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateMissingBothLastNameEmailAddress()
        {
            //Arrange
            var customer = new Customer();
            //customer.FirstName = "Duc";
            //customer.EmailAddress = "dmai0831@gmail.com";

            var expected = false;
            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}
