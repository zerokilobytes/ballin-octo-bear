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
            return "Welcome";
        }
    }
}
