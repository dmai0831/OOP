using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        /// <summary>
        /// Retrieve one customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            //Create the instance of the Customer class
            Customer customer = new Customer(customerId);
            //Establish the relationship between CustomerRepository with AddressRepository
            customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();

            //Temporary hard coded values to return;
            if(customerId==1)
            {
                customer.EmailAddress = "dmai0831@gmail.com";
                customer.FirstName = "Duc";
                customer.LastName = "Mai";
            }

            return customer;
        }
        /// <summary>
        /// Retrieve the list of customer
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            return new List<Customer>();

        }
        /// <summary>
        /// Saves the current customer
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined customer
            return true;
        }
    }
}
