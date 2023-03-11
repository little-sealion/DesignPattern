using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Observer.Stock
{
    public class StatusBar : IObserver
    {
        private List<Stock> _stocks = new();
        public void AddStock(Stock stock)
        {
            _stocks.Add(stock);
            stock.AddObserver(this);
        }
        public void Update()
        {
            System.Console.WriteLine("Price changed, refreshing StatusBar");
            Show();
        }
        public void Show()
        {
            foreach (var stock in _stocks)
                System.Console.WriteLine(stock);
        }
    }
}