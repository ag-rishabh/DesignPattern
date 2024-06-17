using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTradingApp
{
    public interface IStockPublisher
    {
        void Subscribe(IStockSubscriber stockSubscriber);

        void UnSubscribe(IStockSubscriber stockSubscriber);

        void NotifySubscriber(StockName stockName, StockValue stockValue);
    }
}
