using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        /// <summary>
        /// Retrieve one address
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        public Address Retrieve(int addressId)
        {
            // Create the instance of the address class
            Address address = new Address(addressId);

            //Temporary hard coded value to return populated address
            if (addressId == 1)
            { 
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Quincy";
                address.State = "MA";
                address.Country = "United States";
                address.PostalCode = "02169";
            }
            return address;
        }
        //INumberable to return a sequence of data because the result is more flexible.
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            //Temporary hard coded
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2="Bagshot row",
                City="Quincy",
                State="MA",
                Country="United States",
                PostalCode="02169"
            };
            addressList.Add(address);
            address = new Address(2)
            {
                AddressType = 1,
                StreetLine1 = "Green Dragon",
                City = "Dorchester",
                State = "MA",
                Country = "United States",
                PostalCode = "02124"
            };
            addressList.Add(address);

            return addressList;
        }
    }
}
