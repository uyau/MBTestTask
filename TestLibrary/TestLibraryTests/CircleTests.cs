using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void CircleAreaTest()
        {
            double x = 32.1;
            double expected = 3237.1284861854588;

            Circle circle = new Circle(x);
            double actual = circle.Area();

            Assert.AreEqual(expected, actual);
        }
    }
}
