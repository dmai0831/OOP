using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        //When we use static modifier to declare on member. That member is belongs to type itself i.e..Customer rather than any specific instance
        //Using static modifer allows you to declare member that actually belongs the class itself, not to instance of the class
        public static int InstanceCount { get; set; }

        //Use private access modifier to ensure no code outside of this class can access it. This field is stored actual data.
        private string _lastName;
        //Use publish access modifier meaning any code can use it to get or set the data
        //Use internal access modifier if we want the property only be accessed within the current component. Internal means access is limited to code internal to the component
        public string LastName
        {
            //a property contains get and set accessor
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        // use auto-implemented properties. Use this if we don't have business logic in get and set.
        public string FirstName { get; set; }

        public string EmailAddress { get; set; }
        
        //Any class external to this class cannot set this property
        public int CustomerId { get; private set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(LastName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        /// <summary>
        /// Retrieve one customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            //Code that retrieves the defined customer

            return new Customer();
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
        public bool Validate()
        {
            // Assume LastName and EmailAddress are required.
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(LastName))  return false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) return false;

            return isValid;
        }
        public 
    }
}
