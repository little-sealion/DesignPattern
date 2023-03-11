using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.UIControl
{
    public abstract class UIControl
    {
        public void Enable()
        {
            System.Console.WriteLine("Enable");
        }

        public abstract void Draw();
    }
}