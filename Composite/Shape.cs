using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Composite
{
    public class Shape : IComponent
    {
        public void Move()
        {
            System.Console.WriteLine("Move Shape");
        }

        public void Render()
        {
            System.Console.WriteLine("Render shape");
        }
    }
}