using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Flyweight
{
    public class Point
    {
        public Point(int x, int y, PointIcon pointIcon)
        {
            X = x;
            Y = Y;
            PointIcon = pointIcon;
        }
        public int X { get; private set; }
        public int Y { get; private set; }
        public PointIcon PointIcon { get; set; }


        public void Draw()
        {
            System.Console.WriteLine
            (
                $"{Enum.GetName(typeof(PointType), PointIcon.Type)}  at ({X},{Y})"
            );
        }
    }
}