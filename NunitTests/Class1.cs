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

        static object[] circleCases = {
            new int[] {4},
            new int[] {0},
            new int[] {-5}
               
        };

        static object[] SquareCases = {
            new int[] { 7 },
            new int[] { 0 },
            new int[] { -3}
        };

        static object[] TriangleCases = {
            new int[] { 3, 4, 1},
            new int[] { -14, -4, -1}
        };


        /*[Test, TestCaseSource("circleCases")]
        public void isAreaCircleNotNull(int r) {
            Circle a = new Circle(r);
            Assert.IsTrue(a.getAreaCircle() != 0);
        }*/



        /*[Test, TestCaseSource("circleCases")]
        public void isLengthCircleMoreThenNull(int r)
        {
            Circle a = new Circle(r);
            Assert.IsTrue(a.getLengthCircle()  > 0);
        }*/


        [Test, TestCaseSource("circleCases")]
        public void isCircleArgumentsCorrect(int r)
        {
            Circle a = new Circle(r);
            Assert.IsTrue(r > 0);
        }


        [Test, TestCaseSource("circleCases")]
        public void isAreaCircleCorrect(int r)
        {
            Circle a = new Circle(r);
            Assert.AreEqual(a.getAreaCircle(), (Math.PI * Math.Pow(r, 2)));
            Assert.IsTrue(r > 0);
        }



        [Test, TestCaseSource("circleCases")]
        public void isLengthCircleCorrect(int r)
        {
            Circle a = new Circle(r);
            Assert.AreEqual(a.getLengthCircle(), (Math.PI * (r * 2)));
            Assert.IsTrue(r > 0);
        }


        //square

        [Test, TestCaseSource("SquareCases")]
        public void isSquareAreaCorrect(int side) {
            Square s = new Square(side);
            Assert.AreEqual(s.getAreaSquare(), Math.Pow(side, 2));
            Assert.IsTrue(side > 0);
        }


        [Test, TestCaseSource("SquareCases")]
        public void isSquareLengthCorrect(int side)
        {
            Square s = new Square(side);
            Assert.AreEqual(s.getLengthSquare(), side*4);
            Assert.IsTrue(s.getLengthSquare() > 0);
        }



        [Test, TestCaseSource("SquareCases")]
        public void isSquareArgumentsCorrect(int side)
        {
            Square s = new Square(side);
            Assert.IsTrue(side > 0);
        }

        /*[Test, TestCaseSource("SquareCases")]
        public void isSquareAreaMoreThenNull(int side)
        {
            Square s = new Square(side);
            Assert.IsTrue(s.getAreaSquare() > 0);
        }


        [Test, TestCaseSource("SquareCases")]
        public void isSquareLengthMoreThenNull(int side)
        {
            Square s = new Square(side);
            Assert.IsTrue(s.getLengthSquare() > 0);
        }*/


        // triangle


        [Test, TestCaseSource("TriangleCases")]
        public void isTriangleLengthCorrect(int side1, int side2, int side3)
        {
            Triangle t = new Triangle(side1, side2, side3);
            Assert.AreEqual(t.getLengthTriangle(), (side1 + side2 + side3));
            Assert.IsTrue(t.getLengthTriangle() > 0);
        }

        [Test, TestCaseSource("TriangleCases")]
        public void isTriangleAreaCorrect(int side1, int side2, int side3)
        {
            Triangle t = new Triangle(side1, side2, side3);
            double p = (side1 + side2 + side3) / 2;
            double s = Math.Sqrt(p*(p-side1)*(p-side2)*(p-side3));
            Assert.AreEqual(t.getAreaTriangle(), s, 0.0001);
            Assert.IsTrue((side1 > 0) && (side2 > 0) && (side3 > 0));

        }

        [Test, TestCaseSource("TriangleCases")]
        public void isTriangleArgumentsMoreThenNull(int side1, int side2, int side3)
        {
            Triangle t = new Triangle(side1, side2, side3);
            Assert.IsTrue((side1 > 0) && (side2 > 0) && (side3 > 0));
        }

    }

}