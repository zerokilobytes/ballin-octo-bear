using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arisoph.Web.Framework.Services
{
    public class MessageService : IMessageService
    {
        public string GetWelcomeMessage()
        {
            return "Welcome to Ninject MVC4 Example";
        }
    }
}
