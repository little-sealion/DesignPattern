using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    public class Director
    {
        House BuildStandardHouse(HouseBuilder builder)
        {
            builder.AddWalls("wood");
            return builder.Build();
        }
    }
}