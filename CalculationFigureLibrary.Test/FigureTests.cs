using CalculationFigureLibrary.FiguresTypes;
using NUnit.Framework;
using System;
using static System.Math;

namespace CalculationFigureLibrary.Test
{
    public class FigureTests
    {
        [TestCase(1, 1, 1)]
        [TestCase(10, 10, 100)]
        [TestCase(3, 4, 12)]
        [TestCase(1, 10, 10)]
        public void BaseFigureGetSquareTests(int a, int b, int expected)
        {
            BaseFigure firstFigure = new(a, b);
            var actual = firstFigure.GetSquare();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 3.14)]
        [TestCase(3, 28.27)]
        [TestCase(100, 31415.93)]

        public void CircleFigureGetSquareTests(int a, double expected)
        {
            CircleFigure firstFigure = new(a);
            expected = Round(expected, 2);
            var actual = firstFigure.GetSquare();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-1)]
        [TestCase(-10)]
        [TestCase(0)]
        public void CircleFigureGetSquareNegativeTests(int a)
        {
            CircleFigure firstFigure;
            Assert.Throws<ArgumentException>(() =>  firstFigure = new(a));
        }

        [TestCase(4,3,5, 6)]
        [TestCase(3,4,6, 5.33)]
        [TestCase(111,55,62, 1024.33)]

        public void TriangleFigureGetSquareTests(double side
            , double secondSide, double thirdSide, double expected)
        {
            TriangleFigure firstFigure = new(side, secondSide, thirdSide);
            expected = Round(expected, 2);
            var actual = firstFigure.GetSquare();
            Assert.AreEqual(expected, actual);
        }
    }
}