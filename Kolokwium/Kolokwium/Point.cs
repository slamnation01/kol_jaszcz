﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Kol_slam
    {
        public class Point : IEquatable<Point>
        {

            public double x, y;

            public Point(double _x, double _y)
            {
                x = _x;
                y = _y;
            }

            public bool Equals(Point other)
            {
                return x == other.x && y == other.y;
            }
        }
    }


}
