using Ninject.Modules;
//using Ninject.Web.Mvc.FilterBindingSyntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arisoph.Web.Framework.Service
{
   public  class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IService>().To<MockService>();
        }
    }
}
