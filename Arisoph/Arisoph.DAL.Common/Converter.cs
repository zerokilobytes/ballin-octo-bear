using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Arisoph.DAL.Common
{
    public class Converter
    {
        public static double GetAmazonPrice(string price)
        {
            double formatedPrice = 0.0;
            try
            {
                 formatedPrice = Double.Parse(price, CultureInfo.InvariantCulture);
                 return formatedPrice/100.00;
            }
            catch (Exception){}

            return formatedPrice;
        }
    }
}