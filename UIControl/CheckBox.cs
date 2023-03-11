using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.UIControl
{
    public class CheckBox : UIControl
    {
        public override void Draw()
        {
            System.Console.WriteLine("Drawing a checkbox");
        }
    }
}