using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    public class HouseBuilder : IBuilder
    {
        private House _house;
        public IBuilder AddWalls(string wall)
        {
            _house.SetWall(wall);
            return this;
        }
        public IBuilder AddDoors()
        {
            return this;
        }
        public IBuilder AddWindows()
        {
            return this;
        }
        public IBuilder AddRoof()
        {
            return this;
        }
        public IBuilder AddGarage()
        {
            return this;
        }
        public House Build()
        {
            return _house;
        }
    }
}