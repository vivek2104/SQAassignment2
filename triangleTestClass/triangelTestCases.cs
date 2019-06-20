using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ClassLibrary1;

namespace triangleTestClass
{
    [TestFixture]
    public class triangelTestCases
    {

        //test of equilateral triangle
        [Test]
        public void checkEuilateralTriangle()
        {
            //Arrange
            int side1 = 2, side2 = 2, side3 = 2;

            //Act
            String check = triangleSolver.Analyze(side1, side2, side3);
            //Assert
            Assert.AreEqual(check, " This is a equilateral triangle!!!");
        }
        //test case when triangle conditions area not met
        [Test]
        public void Sides2and8and6forNotPossible()
        {
            //Arrange
            int side1 = 1, side2 = 7, side3 = 5;

            //Act
            String check = triangleSolver.Analyze(side1, side2, side3);
            //Assert
            Assert.AreEqual(check, "Triangle cannot be formed");
            
        }
        //test case when one of input size is negative
        [Test]
        public void Sides2and8andNegative6forNotPossible()
        {
            //Arrange
            int side1 = 2, side2 = 8, side3 = -6;

            //Act
            String check = triangleSolver.Analyze(side1, side2, side3);
            //Assert
            Assert.AreEqual(check, "Triangle cannot be formed");

        }
        //test case when any one side size is zero
        [Test]
        public void anySidesare0()
        {
            //Arrange
            int side1 = 0, side2 = 8, side3 = 2;

            //Act
            String check = triangleSolver.Analyze(side1, side2, side3);
            //Assert
            Assert.AreEqual(check, "Triangle cannot be formed");
        }
        //test case to check Isosceles Triangle
        [Test]
        public void checkIsoscelesTriangle()
        {
            //Arrange
            int side1 = 8, side2 = 8, side3 = 6;

            //Act
            String check = triangleSolver.Analyze(side1, side2, side3);
            //Assert
            Assert.AreEqual(check, "This is a isosceles triangle!!!");
        }
        //test case t0 check Scalene triangle
        [Test]
        public void checkScaleneTriangle()
        {
            //Arrange
            int side1 = 3, side2 = 4, side3 = 5;

            //Act
            String check = triangleSolver.Analyze(side1, side2, side3);
            //Assert
            Assert.AreEqual(check, "This is a Scalene triangle!!!");
        }
        //test case to check when two sides are negative
        [Test]
        public void checkInvalidInput()
        {
            //Arrange
            int side1 =- 3, side2 = 4, side3 = -4 ;

            //Act
            String check = triangleSolver.Analyze(side1, side2, side3);
            //Assert
            Assert.AreEqual(check, "Triangle cannot be formed");
        }
        //test case when size in decimals
        [Test]
        public void sizeInDecimals()
        {
            //Arrange
            double side1 = 3.5, side2 = 4, side3 = 4;

            //Act
            String check = triangleSolver.Analyze(side1, side2, side3);
            //Assert
            Assert.AreEqual(check, "This is a isosceles triangle!!!");
        }
    }
}
