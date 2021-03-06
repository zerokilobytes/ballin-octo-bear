﻿using Arisoph.Web.Framework.Service;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;
using Arisoph.Web.Framework.Controllers;

namespace Arisoph.Web.UI.Controllers
{
    public class IndexController : AnonymousController
    {
        private readonly IService message;

       
        public IndexController(IService welcomeMessageService)
        {
            this.message = welcomeMessageService;
        }
      
        public IndexController()
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
