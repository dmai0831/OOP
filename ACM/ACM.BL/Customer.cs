using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
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
                return FirstName + "," + LastName;
            }
        }


    }
}
