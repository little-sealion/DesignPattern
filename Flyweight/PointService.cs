using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Flyweight
{
    public class PointService
    {
        private readonly PointIconFactory _iconFactory;

        public PointService(PointIconFactory iconFactory)
        {
            _iconFactory = iconFactory;
        }

        public List<Point> GetPoints()
        {
            var points = new List<Point>();
            var point = new Point(1, 2, _iconFactory.GetPointIcon(PointType.CAFE));
            points.Add(point);
            return points;
        }
    }
}