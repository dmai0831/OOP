using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {

        }
        // Create overload constructor to take productId
        public Product(int productId)
        {
            this.ProductId = ProductId;   
        }
        public Decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }

       
        /// <summary>
        /// Validate product data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) return false;
            if (CurrentPrice == null) return false;

            return isValid;
        }
    }
}
