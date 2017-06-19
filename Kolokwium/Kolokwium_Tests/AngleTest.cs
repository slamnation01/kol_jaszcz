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

            if (!expectedAngle.Equals(ang.CheckLine()))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        [TestCategory("Logic")]
        public void CheckLine45Angle()
        {
            double expectedAngle = 45;

            int lineNr = 1;

            Point a = new Point(0, 0);
            Point b = new Point(5, 5);

            Line ang = new Line(a, b);

            if (!expectedAngle.Equals(ang.Angle(lineNr)))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        [TestCategory("Logic")]
        public void CheckLine0Angle()
        {
            double expectedAngle = 0;

            int lineNr = 2;

            Point a = new Point(0, 0);
            Point b = new Point(0, 5);

            Line ang = new Line(a, b);

            if (!expectedAngle.Equals(ang.Angle(lineNr)))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        [TestCategory("Logic")]
        public void CheckLineFormula()
        {
            //y = ax + b

            int expectedA = 0, expectedB = 0;

            Line lin = new Line(new Point(0, 0), new Point(10, 0));

            lin.GetFormula();

            if (!(lin.FormA == expectedA)&& (lin.FormB == expectedB))
            {
                Assert.Fail();
            }

        }
    }
}
