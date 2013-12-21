using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;

namespace Arisoph.Common.Log
{
    public class Log
    {
        public static void Info(string message)
        {
            ILog logger = LogManager.GetLogger("File");

            logger.Info(message);
        }


        public static void Debug(string message)
        {
            ILog logger = LogManager.GetLogger("File");

            logger.Debug(message);
        }
    }
}
