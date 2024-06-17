using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTradingApp
{
    public class StockUpdatePublisher : IStockPublisher
    {
        private List<IStockSubscriber> _subscribers;
        private readonly string _name;

        public StockUpdatePublisher(string name)
        {
            _subscribers = new List<IStockSubscriber>();
            _name = name;
        }

        public void NotifySubscriber(StockName stockName, StockValue stockValue)
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.UpdateStock(stockName, stockValue);
            }
        }

        public void Subscribe(IStockSubscriber stockSubscriber)
        {
            _subscribers.Add(stockSubscriber);
        }

        public void UnSubscribe(IStockSubscriber stockSubscriber)
        {
            _subscribers.Remove(stockSubscriber);
        }
    }
}
