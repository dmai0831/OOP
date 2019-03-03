using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product: EntityBase, ILoggable
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

        private string _productName;

        public string ProductName
        {
            get {
                
                //return StringHandler.InsertSpaces(_productName);
                return _productName.InsertSpaces();
            }
            set { _productName = value; }
        }



        /// <summary>
        /// Validate product data.
        /// </summary>
        /// <returns></returns>
        public override  bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) return false;
            if (CurrentPrice == null) return false;

            return isValid;
        }
        public override string ToString()
        {
            //return base.ToString();
            return ProductName;
        }

        public string Log()
        {
            var logString = this.ProductId + ": " +
                            this.ProductName + " " +
                            "Detail: " + this.ProductDescription +
                            "Status: " + this.EntityState.ToString();

            return logString;
        }
    }
}
