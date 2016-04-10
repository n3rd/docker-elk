using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogstashTest
{
    public class MyClass
    {

        static ILogger _logger = LogManager.GetCurrentClassLogger();

        public void DoSomeThing()
        {
            _logger.Debug("Debug test");

            _logger.Warn("Warn test");

            _logger.Error("Error test");

            throw new Exception("thrown exception from MyClass");
        }

    }
}
