using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class DebugLogger : ILogger
    {
        private readonly ILogger _nextLogger;
        private readonly IPublisher _publisher;

        public DebugLogger(ILogger logger, IPublisher publisher)
        {
            _nextLogger = logger;
            _publisher = publisher;
        }


        public void Log(LogLevel level, string message)
        {
            if (level == LogLevel.DEBUG)
            {
                _publisher?.Nofity(message);
            }
            _nextLogger?.Log(level, message);
        }
    }
}
