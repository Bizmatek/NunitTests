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

        static int[] circleCases = {-1,0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30};

        static int[] SquareCases = { -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

        static object[] TriangleCases = {
            new int[] {-1, -1, -1},
            new int[] { 0, 0, 0},
            new int[] { 1, 1, 1},
            new int[] { 2, 2, 2},
            new int[] { 3, 3, 3},
            new int[] { 4, 4, 4},
            new int[] { 5, 5, 5},
            new int[] { 6, 6, 6},
            new int[] { 7, 7, 7},
            new int[] { 8, 8, 8},
            new int[] { 9, 9, 9},
            new int[] { 10, 10, 10},
            new int[] { 11, 11, 11},
            new int[] { 12, 12, 12},
            new int[] { 13, 13, 13},
            new int[] { 14, 14, 14},
            new int[] { 15, 15, 15},
            new int[] { 16, 16, 16},
            new int[] { 17, 17, 17},
            new int[] { 18, 18, 18},
            new int[] { 19, 19, 19},
            new int[] { 20, 20, 20},
            new int[] { 21, 21, 21},
            new int[] { 22, 22, 22},
            new int[] { 23, 23, 23},
            new int[] { 24, 24, 24},
            new int[] { 25, 25, 25},
            new int[] { 26, 26, 26},
            new int[] { 27, 27, 27},
            new int[] { 28, 28, 28},
            new int[] { 29, 29, 29},
            new int[] { 30, 30, 30},
        };

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