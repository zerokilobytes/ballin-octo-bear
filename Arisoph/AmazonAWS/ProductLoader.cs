using Arisoph.DAL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Arisoph.Common.Log;
using Arisoph.Common;
namespace Arisoph.DAL.Amazon.AWS
{
    public class ProductLoader
    {
        public static List<ResultItem> Load(string search, string category)
        {
            var url = ItemLookup.GetURL(search, category);




            XNamespace ns = XNamespace.Get("http://webservices.amazon.com/AWSECommerceService/2011-08-01");

            var doc = XDocument.Load(url);
            Log.Debug("\n" + doc.ToString());

            var items = (from c in doc.Descendants(ns + "Item")
                         where c.Descendants(ns + "ListPrice").Count() > 0
                         select new ResultItem
                         {
                             Title = c.Element(ns + "ItemAttributes").Element(ns + "Title").Value.Ellipsis(50),
                             Description = c.Element(ns + "ItemAttributes").Element(ns + "Title").Value.Ellipsis(100),
                             Price = Converter.GetAmazonPrice(c.Element(ns + "ItemAttributes").Element(ns + "ListPrice").Element(ns + "Amount").Value),
                             ID = c.Element(ns + "ASIN").Value,
                             URL = c.Element(ns + "DetailPageURL").Value,
                             Source = "www.awazon.com",
                             FormattedPrice = c.Element(ns + "ItemAttributes").Element(ns + "ListPrice").Element(ns + "FormattedPrice").Value,
                             CurrencyCode = c.Element(ns + "ItemAttributes").Element(ns + "ListPrice").Element(ns + "CurrencyCode").Value
                         }).ToList<ResultItem>();

            return items.Where(x => x.Price > 0).ToList();
        }
    }
}
