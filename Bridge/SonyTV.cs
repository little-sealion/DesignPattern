using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Bridge
{
    public class SonyTV : IDevice
    {
        public void SetChannel(int number)
        {
            System.Console.WriteLine("sony set channel");
        }

        public void TurnOff()
        {
            System.Console.WriteLine("sony turn off");
        }

        public void TurnOn()
        {
            System.Console.WriteLine("sony turn on");
        }
    }
}