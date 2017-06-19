using Kolokwium.Kol_slam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    public class Line
    {
        public List<Point> EndPoints = new List<Point>();

        public Line(int ax, int ay, int bx, int by)
        {
            EndPoints = new List<Point>
            {
                new Point(ax, ay),
                new Point(bx, by)
            };
        }

        public double Line1Angle()
        {

            return;
        }

    }
}
