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
               new object[] { 5 }, //, 7, 3, 3,  3},
               new object[] { 2 },//, 9, 2, 1, 5 },
               new object[] { 1 },//, 3, 7, 4, 5 }
        };

        static object[] circleCases = {
                new object[] { 5},
                new object[] { 7},
                new object[] { 8}
        };

        [Test,  TestCaseSource("circleCases")]

        public void test1(int rad) {

            Circle a = new Circle(rad);
            Assert.AreEqual(a.getAreaCircle(), (Math.PI * Math.Pow(rad, 2)));
        }

         //[TestFixtureSetUp, TestCaseSource("figureCases")]
        //  public void initObjects(int circleRadius, int squareSide, int triangleSide1, int triangleSide2, int triangleSide3 ) {
        //public void initObjects(int circleRadius) {
          //  Circle circle = new Circle(circleRadius);
       // }
        //     Circle circle = new Circle(circleRadius);
       //     Square square = new Square(squareSide);
      //      Triangle triangle = new Triangle(triangleSide1, triangleSide2, triangleSide3);
      //  }

    }

}