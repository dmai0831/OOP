using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieve one product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            //Create the instance of the Product class
            //Pass in the requested Id
            Product product = new Product();

            //Temporary hard coded values to return a populated product
            if(productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size";
                product.CurrentPrice = 15M;
  
            }

            return product;
        }
        /// <summary>
        /// Retrieve the list of product
        /// </summary>
        /// <returns></returns>
        public List<Product> Retrieve()
        {
            return new List<Product>();
        }
        /// <summary>
        /// Saves the current product
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            bool success = true;
            if (product.HasChanges && product.IsValid)
            {
                if (product.IsNew)
                {
                    //Call an insert stored procedure
                }
                else
                {
                    // call an update stored procedure
                }
            }
            return success;
        }
    }
}
