using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    public interface IBuilder
    {
        IBuilder AddWalls(string wall);
        IBuilder AddDoors();
        IBuilder AddWindows();
        IBuilder AddRoof();
        IBuilder AddGarage();
        House Build();
    }
}