using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Observer.Stock
{
    public class Subject
    {
        private List<IObserver> _observers = new();
        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void AddObservers(List<IObserver> observers)
        {
            _observers.AddRange(observers);
        }
        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}