using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
    public class SpreadSheet : IObserver
    {
        public void Update(int message)
        {
            System.Console.WriteLine("Spreadsheet get notified");
        }
    }
}