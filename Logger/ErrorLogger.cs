﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class ErrorLogger : ILogger
    {   
        private readonly ILogger _nextLogger;
        private readonly IPublisher _publisher;

        public ErrorLogger(ILogger logger, IPublisher publisher)
        {
            _nextLogger = logger;
            _publisher = publisher;
        }


        public void Log(LogLevel level, string message)
        {
            if (level == LogLevel.ERROR)
            {
                _publisher?.Nofity(message);
            }
            _nextLogger?.Log(level, message);
        }
    }
}
