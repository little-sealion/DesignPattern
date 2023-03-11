using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Template
{
    public class BounceWindow : BaseWindow
    {
        protected override void AfterClose()
        {
            System.Console.WriteLine("Bounce after closing Bounce window");
        }

        protected override void BeforeClose()
        {
            System.Console.WriteLine("Bounce before closing Bounce window");
        }
    }
}