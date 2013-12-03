using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Arisoph.Web.Framework.Infrastructure;

namespace Arisoph.Web.Framework.ActionFilter
{
    public class LogFilter : IActionFilter
    {
        private readonly ILog log;
        private readonly Level logLevel;

        public LogFilter(ILog log, Level logLevel)
        {
            this.log = log;
            this.logLevel = logLevel;
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //var message = string.Format(
            //        CultureInfo.InvariantCulture,
            //        "Executing action {0}.{1}",
            //        filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
            //        filterContext.ActionDescriptor.ActionName),
            //this.log.Logger.Log(typeof(LogFilter), this.logLevel, message, null);
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //var message = string.Format(
            //        CultureInfo.InvariantCulture,
            //        "Executed action {0}.{1}",
            //        filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
            //        filterContext.ActionDescriptor.ActionName),
            //this.log.Logger.Log(typeof(LogFilter), this.logLevel, message, null);
        }
    }
}
