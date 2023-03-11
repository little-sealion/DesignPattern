using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
    public class DataSource : Subject
    {
        public int Value { get; private set; }
        public void SetValue(int newValue)
        {
            Value = newValue;
            NotifyObservers(Value);
        }
    }
}