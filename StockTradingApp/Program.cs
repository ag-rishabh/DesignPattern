using StockTradingApp;

IStockPublisher BSEPublisher = new StockUpdatePublisher("BSE");
IStockPublisher NSEPublisher = new StockUpdatePublisher("NSE");

IStockSubscriber subscriber1 = new StockUpdateSubscriber("perser1");
IStockSubscriber subscriber2 = new StockUpdateSubscriber("perser2");
IStockSubscriber subscriber3 = new StockUpdateSubscriber("perser3");

NSEPublisher.Subscribe(subscriber1);
NSEPublisher.Subscribe(subscriber2);


BSEPublisher.Subscribe(subscriber3);
BSEPublisher.Subscribe(subscriber2);

NSEPublisher.NotifySubscriber(StockName.TESLA, new StockValue(1, 100, Curreny.INR));
NSEPublisher.NotifySubscriber(StockName.PNB, new StockValue(1, 130, Curreny.INR));
NSEPublisher.NotifySubscriber(StockName.TESLA, new StockValue(2, 200, Curreny.INR));
NSEPublisher.NotifySubscriber(StockName.PNB, new StockValue(1, 125, Curreny.INR));


