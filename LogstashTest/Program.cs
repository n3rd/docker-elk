using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogstashTest
{
    class Program
    {
        static ILogger _logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            _logger.Debug("Debug test");

            _logger.Error("Error test");

            try
            {
                new MyClass().DoSomeThing();
            }
            catch(Exception e)
            {
                _logger.Error(e, "Thrown error exception test");
            }
        }
    }
}
