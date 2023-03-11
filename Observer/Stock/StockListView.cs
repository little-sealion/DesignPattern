using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Observer.Stock
{
    public class StockListView : IObserver
    {
        private List<Stock> _stocks = new();
        public void AddStock(Stock stock)
        {
            _stocks.Add(stock);
            stock.AddObserver(this);
        }
        public void Update()
        {
            System.Console.WriteLine("Price changed, refreshing Stock List");
            Show();
        }
        public void Show()
        {
            foreach (var stock in _stocks)
                System.Console.WriteLine(stock);
        }
    }
}