using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public class BWFilter : IFilter
    {
        public void Apply(string image)
        {
            System.Console.WriteLine($"Applying b&w filter on {image}");
        }
    }
}