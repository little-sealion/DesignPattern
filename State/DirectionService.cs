using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.State
{
    public class DirectionService
    {
        public ITravelMode CurrentTravelMode { get; set; } = null!;
        public float GetETA()
        {
            return CurrentTravelMode.GetETA();
        }
        public int GetDirection()
        {
            return CurrentTravelMode.GetDirection();
        }
    }
}