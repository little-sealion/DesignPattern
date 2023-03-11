using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.UIControl
{
    public class TextBox : UIControl
    {
        public override void Draw()
        {
            System.Console.WriteLine("Drawing a textbox");
        }
    }
}