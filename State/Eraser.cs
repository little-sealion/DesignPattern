using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.State
{
    public class Eraser : Tool
    {
        public override void MouseDown()
        {
            System.Console.WriteLine("Eraser icon");
        }

        public override void MouseUp()
        {
            System.Console.WriteLine("Erase a line");
        }
    }
}