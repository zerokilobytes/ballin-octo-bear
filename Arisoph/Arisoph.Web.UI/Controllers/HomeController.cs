using Arisoph.Web.Framework.Service;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;

namespace Arisoph.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService message;

       
        public HomeController(IService welcomeMessageService)
        {
            this.message = welcomeMessageService;
        }
      
        public HomeController()
        {
            
        }
        public ActionResult Index()
        {
            ViewBag.Message = message.GetMessage();

            
            //log4net.ILog logger = log4net.LogManager.GetLogger("File");
          
            //logger.Error("Front page loaded for ip " + Request.UserHostAddress);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
