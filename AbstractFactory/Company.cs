using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public abstract class Company
    {
        // can add business logic here
        public abstract IGpu CreateGpu();

        public abstract IMonitor CreateMonitor();
    }

}