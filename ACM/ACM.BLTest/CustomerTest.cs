using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
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
    }
}
