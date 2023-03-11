using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Command
{
    public class BlackWhiteCommand : ICommand
    {
        public void Execute()
        {
            System.Console.WriteLine("Apply black and white filter");
        }
    }
}