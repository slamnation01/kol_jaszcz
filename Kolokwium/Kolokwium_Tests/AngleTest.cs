using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kolokwium;
using Kolokwium.Kol_slam;

namespace Kolokwium_Tests
{
    [TestClass]
    public class AngleTest
    {

        [TestMethod]
        [TestCategory("Logic")]
        public void CheckLine1Angle()
        {
            double expectedAngle = 45;

            Point a = new Point(0, 0);
            Point b = new Point(5, 5);

            Line ang = new Line(a, b);

            if (!expectedAngle.Equals(ang.Line1Angle()))
            {
                Assert.Fail();
            }
        }


    }
}
