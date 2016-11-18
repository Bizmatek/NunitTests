using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using NUnit.Framework;



namespace GeometricFigures
{

    [TestFixture]

    public class NUnitTests

    {

        static object[] figureCases = {
               new object[] { 5, 7, 3, 7, 4 },
               new object[] { 2, 9, 2, 1, 5 },
               new object[] { 1, 3, 7, 4, 5 }
        };

        [Test]

        public void test1() {

            Circle a = new Circle(5);
            Assert.AreEqual(a.getAreaCircle(), (Math.PI * Math.Pow(5, 2)));
        }

        [TestFixtureSetUp, TestCaseSource("figureCases")]
        public void initObjects(int circleRadius, int squareSide, int triangleSide1, int triangleSide2, int triangleSide3 ) {
            Circle circle = new Circle(circleRadius);
            Square square = new Square(squareSide);
            Triangle triangle = new Triangle(triangleSide1, triangleSide2, triangleSide3);
        }

    }

}