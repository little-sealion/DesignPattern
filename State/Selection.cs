using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.State
{
    public class Selection : Tool
    {

        public override void MouseDown()
        {
            System.Console.WriteLine("Selection icon");
        }

        public override void MouseUp()
        {
            System.Console.WriteLine("Draw dashed rectangle");
        }
    }
}