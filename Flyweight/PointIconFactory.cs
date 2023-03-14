using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Flyweight
{
    public class PointIconFactory
    {
        private Dictionary<PointType, PointIcon> _icons = new();
        public PointIcon GetPointIcon(PointType type)
        {
            // key -> value
            // PointType -> PointIcon
            if (!_icons.ContainsKey(type))
            {
                // in real system, we should read an icon file from system into byte[]
                var pointIcon = new PointIcon(type, icon: null);
                _icons.Add(type, pointIcon);
            }
            return _icons[type];
        }
    }
}