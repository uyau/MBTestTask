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
    public class TriangleTests
    {
        [TestMethod()]
        public void TriangleAreaTest()
        {
            double a = 12.4;
            double b = 11;
            double c = 5.78;
            double expected = 31.78958671625033;

            Triangle triangle = new Triangle(a,b,c);
            double actual = triangle.Area();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TriangleIsRectangularTest()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            bool expected = true;

            Triangle triangle = new Triangle(a, b, c);
            bool actual = triangle.IsRectangular();

            Assert.AreEqual(expected, actual);
        }
    }
}