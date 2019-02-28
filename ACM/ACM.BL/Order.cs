﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {
                
        }
        // Create overload constructor to take orderId
        public Order(int orderId)
        {
            this.OrderId = orderId;
        }
        //DateTimeOffset is a value type tracks the date time and timezone offset. 
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        
        /// <summary>
        /// Retrieve one order
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
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
            if(OrderDate == null) return false;

            return isValid;
        }
    }
}