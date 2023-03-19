using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    public class House
    {
        public string Wall { get; private set; } = null!;
        public void SetWall(string wall)
        {
            Wall = wall;
        }
    }
}