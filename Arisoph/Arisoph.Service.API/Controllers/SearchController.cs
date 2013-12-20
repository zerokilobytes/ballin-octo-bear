using Arisoph.DAL.Amazon.AWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Arisoph.Service.API.Controllers
{
    public class SearchController : Controller
    {
        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public ActionResult Index(FormCollection form)
        {
            if (Request.HttpMethod == "POST")
            {
                string query = form["query"].ToString();

                var products = ProductLoader.Load(query, "Electronics");

                return Json(products, JsonRequestBehavior.AllowGet
               );
              
            }

            return View();
        }
    }
}
