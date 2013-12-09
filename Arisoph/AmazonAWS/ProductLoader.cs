using Arisoph.DAL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AmazonAWS
{
    public class ProductLoader
    {
        public static List<ResultItem> Load()
        {
            var url = ItemLookup.GetURL(null);

           


            XNamespace ns = XNamespace.Get( "http://webservices.amazon.com/AWSECommerceService/2011-08-01");

            var doc = XDocument.Load(url);


            var items = (from c in doc.Descendants(ns + "Item")
                         where c.Descendants(ns + "ListPrice").Count() > 0
                         select new ResultItem
                         {
                              Name = c.Element(ns + "ItemAttributes").Element(ns + "Title").Value,
                              Price = c.Element(ns + "ItemAttributes").Element(ns + "ListPrice").Element(ns + "Amount").Value,
                            //Price = c.Element(ns + "ASIN").Value
                         }).ToList<ResultItem>();

            return items.ToList();
        }
    }
}
