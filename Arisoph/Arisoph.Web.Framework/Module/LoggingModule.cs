using Arisoph.Web.Framework.ActionFilter;
using Arisoph.Web.Framework.Infrastructure;
using Arisoph.Web.Framework.Infrastructure.Log;
using Ninject.Activation;
using Ninject.Modules;
using Ninject.Web.Mvc.Filter;
using Ninject.Web.Mvc.FilterBindingSyntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Arisoph.Web.Framework.Module
{
    public class LoggingModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<ILog>().ToMethod(GetLogger);
            // [FIX-2013-11-16]: Note that you have to use this because BindFilter is an 
            // extension method, and you also have to reference the Ninject.Web.Mvc.FilterBindingSyntax namespace.
            this.BindFilter<LogFilter>(FilterScope.Controller, 0).WithConstructorArgument("logLevel", Level.Info);
        }

        private static ILog GetLogger(IContext ctx)
        {
            var filterContext = ctx.Request.ParentRequest.Parameters
                          .OfType<FilterContextParameter>().SingleOrDefault();
            return LogManager.GetLogger(filterContext == null ?
                ctx.Request.Target.Member.DeclaringType :
                filterContext.ActionDescriptor.ControllerDescriptor.ControllerType);
        }
    }
}
