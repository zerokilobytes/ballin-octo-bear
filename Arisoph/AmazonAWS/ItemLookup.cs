
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Linq;

namespace AmazonAWS
{
   public class ItemLookup
    {
        private const string MY_AWS_ACCESS_KEY_ID = "AKIAIYMSGU5E5OTDRTYA";
        private const string MY_AWS_SECRET_KEY = "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";
        private const string DESTINATION          = "ecs.amazonaws.com";

        public static string GetURL(List<string> keywords)
        {
            SignedRequestHelper helper = new SignedRequestHelper(MY_AWS_ACCESS_KEY_ID, MY_AWS_SECRET_KEY, DESTINATION);
            String requestUrl;

            IDictionary<string, string> r1 = new Dictionary<string, String>();
            r1["Service"] = "AWSECommerceService";
            r1["Version"] = "2011-08-01";
            r1["ResponseGroup"] = "Small";
            r1["AssociateTag"] = "httpzerokilow-20";
            r1["ResponseGroup"] = "ItemAttributes";
            r1["MerchantId"] = "All";
            r1["Operation"] = "ItemSearch";
            r1["SearchIndex"] = "Electronics";
            r1["Keywords"] = "samsung galaxy s4";

            requestUrl = helper.Sign(r1);
            return requestUrl;
            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load(requestUrl);

            //var document = XDocument.Load(requestUrl);
        }
    }
}