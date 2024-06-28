using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class InfoLogger : ILogger
    {
        private readonly ILogger _nextLogger;
        private readonly IPublisher _publisher;

        public InfoLogger(ILogger logger, IPublisher publisher)
        {
            _nextLogger = logger;
            _publisher = publisher;
        }


        public void Log(LogLevel level, string message)
        {
            if (level == LogLevel.INFO)
            {
                _publisher?.Nofity(message);
            }
            _nextLogger?.Log(level, message);
        }
    }
}
