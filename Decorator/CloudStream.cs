using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public class CloudStream : IStream
    {
        public virtual void Write(string data)
        {
            System.Console.WriteLine("Storing " + data);
        }
    }
}