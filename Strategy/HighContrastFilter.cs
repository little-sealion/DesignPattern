using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public class HighContrastFilter : IFilter
    {
        public void Apply(string image)
        {
            System.Console.WriteLine($"Applying high contrast filter on {image}");
        }
    }
}