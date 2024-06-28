using Logger;

IPublisher debugInfoPub = new LogPublisher();
debugInfoPub.Subscribe(new ConsoleSubscriber());

IPublisher warnAndAbove = new LogPublisher();
warnAndAbove.Subscribe(new ConsoleSubscriber());
warnAndAbove.Subscribe(new FileSubscriber("log.txt"));

ILogger logger = new DebugLogger(new InfoLogger(new WarnLogger(new ErrorLogger(null, warnAndAbove), warnAndAbove), debugInfoPub), debugInfoPub);
logger.Log(LogLevel.WARN, "Warning message");