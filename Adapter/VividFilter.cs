using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
    public class VividFilter : IFilter
    {
        public void Apply(Image image)
        {
            System.Console.WriteLine("Apply vivid filter");
        }
    }
}