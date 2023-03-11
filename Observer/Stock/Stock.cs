using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Observer.Stock
{
    public class Stock : Subject
    {
        public string Symbol { get; private set; } = null!;
        public float Price { get; private set; }
        public Stock(string symbol, float price)
        {
            Symbol = symbol;
            Price = price;
        }

        public void SetPrice(float price)
        {
            Price = price;
            NotifyObservers();
        }
        public override string ToString()
        {
            return "Stock{" +
                "symbol='" + Symbol + '\'' +
                ", price=" + Price +
                '}';
        }
    }
}