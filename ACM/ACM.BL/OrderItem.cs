using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        // Create overload constructor to take orderItemId
        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }
        public int OrderItemId { get; private set; }
        public int OrderQuantity { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Retrieve one order
        /// </summary>
        /// <param name="orderItemId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderItemId)
        {
            return new Order();
        }
        /// <summary>
        /// Saves the current product
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }
        /// <summary>
        /// Validate product data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;
            if (OrderQuantity <= 0) return false;
            if (ProductId <= 0) return false;
            if (PurchasePrice == null) return false;

            return isValid;
        }
    }
}
