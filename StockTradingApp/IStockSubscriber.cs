using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StockTradingApp
{
    public interface IStockSubscriber
    {
        void UpdateStock(StockName stockName, StockValue stockValue);
    }
}
