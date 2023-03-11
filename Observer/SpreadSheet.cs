using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
    // Each concrete IObserver class is now dependt on concrete subject class,
    // so we can implement pull style, to selectively choose to get certain data from
    // the concrete subject class
    public class SpreadSheet : IObserver
    {
        private readonly DataSource _dataSource;

        public SpreadSheet(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            System.Console.WriteLine("SpreadSheet get notified: " + _dataSource.Value);
        }
    }
}