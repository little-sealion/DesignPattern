using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.State
{
    public class Brush : Tool
    {
        public override void MouseDown()
        {
            System.Console.WriteLine("Brush icon");
        }

        public override void MouseUp()
        {
            System.Console.WriteLine("Draw a line");
        }
    }
}