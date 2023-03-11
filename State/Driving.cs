using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.State
{
    public class Driving : ITravelMode
    {
        public int GetDirection()
        {
            System.Console.WriteLine("Caculating Direction (driving)");
            return 1;
        }

        public float GetETA()
        {
            System.Console.WriteLine("Caculating ETA (driving)");
            return 0.34f;
        }
    }
}