using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.State
{
    public abstract class Tool
    {
        public abstract void MouseDown();
        public abstract void MouseUp();
    }
}