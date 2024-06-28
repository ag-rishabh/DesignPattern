using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class WarnLogger : ILogger
    {
        private readonly ILogger _nextLogger;
        private readonly IPublisher _publisher;

        public WarnLogger(ILogger logger, IPublisher publisher)
        {
            _nextLogger = logger;
            _publisher = publisher;
        }


        public void Log(LogLevel level, string message)
        {
            if (level == LogLevel.WARN)
            {
                _publisher?.Nofity(message);
            }
            _nextLogger?.Log(level, message);
        }
    }
}
