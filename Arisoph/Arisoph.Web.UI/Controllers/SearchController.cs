using AmazonAWS;
using Arisoph.Web.Framework.Controllers;
using Arisoph.Web.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Arisoph.Web.UI.Controllers
{
    public class SearchController : AnonymousController
    {

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public ActionResult Index(FormCollection form)
        {
            if (Request.HttpMethod == "POST")
            {
                string query = form["query"].ToString();
                var products = new AmazonProduct[]
                 {
                     new AmazonProduct() {  name = "Bread"} 
                 };


               var result =  ProductLoader.Load();

                return View("Index", null, products.ToList());
            }

            return View();
        }
    }
}