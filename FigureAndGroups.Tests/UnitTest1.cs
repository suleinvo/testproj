using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiguresAndGroups.UserModelExample;
using System.Collections.Generic;

namespace FigureAndGroups.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private Random _rand = new Random();

        [TestMethod]
        public void MeasureTests()
        {
            var a1 = _rand.Next();
            var a2 = _rand.Next();
            var a3 = _rand.Next();
            var square = new Square(new List<double>(){a1,a2});
            Assert.AreEqual(square.GetMeasure(), a1*2 + a2*2);
            var tryangle = new Tryangle(new List<double>() { a1,a2,a3});
            Assert.AreEqual(square.GetMeasure(), a1 + a2 + a3);
            var circle = new Circle(2);

        }
    }
}
