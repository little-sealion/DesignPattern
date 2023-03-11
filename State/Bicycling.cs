using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.State
{
    public class Bicycling : ITravelMode
    {
        public int GetDirection()
        {
            System.Console.WriteLine("Caculating Direction (Bicycling)");
            return 2;
        }

        public float GetETA()
        {
            System.Console.WriteLine("Caculating ETA (Bicycling)");
            return 0.54f;
        }
    }
}