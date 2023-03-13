using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Adapter.AvaFilters
{
    public class Caramel
    {
        public void Init() { }
        public void Render(Image image)
        {
            System.Console.WriteLine("Applying Caramel Filter");
        }
    }
}