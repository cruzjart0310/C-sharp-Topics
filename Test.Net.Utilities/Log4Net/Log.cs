using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch =true)]

namespace Test.Net.Utilities.Log4Net
{
    public static class Log
    {
        //https://youtu.be/2lAdQ_QwNww
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static void Error(string message)
        {
            log.Error(message);
        }
    }
}
