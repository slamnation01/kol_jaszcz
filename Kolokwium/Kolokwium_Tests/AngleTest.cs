using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kolokwium;

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

            Angle ang = new Angle(a, b);

            if (!expectedAngle.Equals(ang.Line1Angle()))
            {
                Assert.Fail();
            }
        }
    }
}
