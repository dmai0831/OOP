using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public static class StringHandler
    {
        //Add "this" keyword make the method extension
        //For example: productName.InsertSpace() instead of StringHandler.InsertSpace(productName);
        /// <summary>
        /// Insert space between word
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpaces(this string source)
        {
            string result = string.Empty;
            if(!String.IsNullOrWhiteSpace(source))
            {
                foreach(char letter in source)
                {
                    if(char.IsUpper(letter))
                    {
                        //Trim any spaces already there
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
            }

            return result.Trim();
        }
        
    }
}
