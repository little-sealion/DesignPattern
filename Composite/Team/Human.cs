using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Composite.Team
{
    public class Human : IResource
    {
        public void Deploy()
        {
            System.Console.WriteLine("Deploying a human resource");
        }
    }
}