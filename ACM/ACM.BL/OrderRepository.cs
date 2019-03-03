using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay();

            //Temporary hard coded
            if(orderId ==10)
            {
                orderDisplay.FirstName = "Duc";
                orderDisplay.LastName = "Mai";
                orderDisplay.OrderDate = new DateTimeOffset(2019, 2, 28, 23, 0, 0, TimeSpan.FromHours(+3));
                orderDisplay.ShippingAddress = new Address()
                {
                    AddressType=1,
                    StreetLine1="Bag End",
                    StreetLine2="Bagshot row",
                    City="Quincy",
                    State="MA",
                    Country="United States",
                    PostalCode="02169"
                };
            }
            orderDisplay.orderDisplayItemList = new List<OrderDisplayItem>();
            //Temporary hard coded
            if (orderId == 10)
            {
                var orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName="Sunflowers",
                    PurchasePrice=15.9M,
                    OrderQuantity=2
                };
                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);

                orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Rake",
                    PurchasePrice = 6M,
                    OrderQuantity = 1
                };
                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);
            }

            return orderDisplay;
        }
        /// <summary>
        /// Retrieve one order
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            Order order = new Order();
            if(orderId==10)
            {
                order.OrderDate = new DateTimeOffset(2019, 2, 28, 10, 18, 0, TimeSpan.FromHours(+3));
            }

            return order;
        }
        /// <summary>
        /// Saves the current product
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }
    }
}
