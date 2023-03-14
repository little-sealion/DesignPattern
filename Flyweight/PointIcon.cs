using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Flyweight
{
    public class PointIcon
    {
        public PointType Type { get; private set; }
        public byte[]? Icon { get; private set; }

        public PointIcon(PointType type, byte[]? icon)
        {
            Type = type;
            Icon = icon;
        }
    }
}