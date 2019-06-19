﻿using System;
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
    }
}