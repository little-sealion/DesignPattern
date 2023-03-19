using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public class AsusManufacturer : Company
    {
        public override IGpu CreateGpu()
        {
            return new AsusGpu();
        }

        public override IMonitor CreateMonitor()
        {
            return new AsusMonitor();
        }
    }
}