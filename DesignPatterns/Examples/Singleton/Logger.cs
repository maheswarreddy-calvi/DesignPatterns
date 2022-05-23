using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Examples.Singleton
{
    public sealed class Logger
    {
        private static readonly Logger _logger = new Logger();

        private Logger()
        {

        }

        public static Logger GetLogger()
        {
            return _logger;
        }

        public void WriteMessage(string msg)
        {
            // Access a file and logs the msg
        }
    }
}
