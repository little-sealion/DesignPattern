using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Composite.Team
{
    public class Truck : IResource
    {
        public void Deploy()
        {
            System.Console.WriteLine("Deploying a truck");
        }
    }
}