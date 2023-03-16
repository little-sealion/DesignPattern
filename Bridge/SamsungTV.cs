using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Bridge
{
    public class SamsungTV : IDevice
    {
        public void SetChannel(int number)
        {
            System.Console.WriteLine("Samsung set channel");
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Samsung turn off");
        }

        public void TurnOn()
        {
            System.Console.WriteLine("Samsung turn on");
        }
    }
}