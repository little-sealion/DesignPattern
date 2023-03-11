using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
    public class Chart : IObserver
    {
        public void Update(object newValue)
        {
            System.Console.WriteLine("Chart get notified,new value: " + newValue);
        }
    }
}