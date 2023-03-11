using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Template
{
    public class BumpWindow : BaseWindow
    {
        protected override void AfterClose()
        {
            System.Console.WriteLine("Bump after closing bump window");
        }

        protected override void BeforeClose()
        {
            System.Console.WriteLine("Bump before closing bump window");
        }
    }
}