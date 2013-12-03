using Arisoph.Web.Framework.Service;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Arisoph.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService welcomeMessageService;

        [Inject]
        public HomeController(IService welcomeMessageService)
        {
            this.welcomeMessageService = welcomeMessageService;
        }

        public ActionResult Index()
        {
            ViewBag.Message = welcomeMessageService.GetMessage();

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
