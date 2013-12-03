using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arisoph.Web.Framework.Service
{
    public class MockService : IService
    {
        public string GetMessage()
        {
            return "1. Modify this template to jump-start your ASP.NET MVC application.";
        }
    }
}
