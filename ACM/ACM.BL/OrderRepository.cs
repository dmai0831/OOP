using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
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
