using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTradingApp
{
    public class StockUpdateSubscriber : IStockSubscriber
    {
        private readonly string _name;
        private Dictionary<StockName, StockValue> _stockValue;
        private List<IStockPublisher> _publishers;

        public StockUpdateSubscriber(string name)
        {
            _name = name;
            _stockValue = new Dictionary<StockName, StockValue>();
            _publishers = new List<IStockPublisher>();
        }

        public void UpdateStock(StockName stockName, StockValue stockValue)
        {
            Console.WriteLine($"{_name} {stockName} {stockValue.Amount} {stockValue.Curreny} {stockValue.VersionNumber}");
            if(!_stockValue.ContainsKey(stockName))
            {
                _stockValue.Add(stockName, stockValue);
            } 
            else if (_stockValue[stockName].VersionNumber < stockValue.VersionNumber)
            {
                _stockValue[stockName] = stockValue;
            }
        }
    }
}
