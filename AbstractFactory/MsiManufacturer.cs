using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public class MsiManufacturer : Company
    {
        public override IGpu CreateGpu()
        {
            return new MsiGpu();
        }

        public override IMonitor CreateMonitor()
        {
            return new MsiMonitor();
        }
    }
}