using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Template
{
    public abstract class BaseWindow
    {
        public void Close()
        {
            BeforeClose();
            System.Console.WriteLine("Closing window");
            AfterClose();
        }

        protected abstract void AfterClose();

        protected abstract void BeforeClose();
    }
}