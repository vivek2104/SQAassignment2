﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class triangleSolver
    {
        public static string Analyze(double side1, double side2, double side3)
        {
            double sSide1 = side1 + side2;
            double sSide2 = side2 + side3;
            double sSide3 = side3 + side1;

            if (sSide1 > side3 && sSide2 > side1 && sSide3 > side2)
            {
                if (side1 == side2 && side2 == side3)
                {
                    //Console.WriteLine("This is a equilateral triangle!!!");
                    return " This is a equilateral triangle!!!";
                }
                else if (side1 == side2 || side2 == side3 || side3 == side1)
                {
                    //Console.WriteLine("This is a isosceles triangle");
                   return "This is a isosceles triangle!!!" ;
                }
                else
                {
                    //Console.WriteLine("This is a Scalene triangle");
                    return "This is a Scalene triangle!!!";
                } 
            
            }
         else return "Triangle cannot be formed";
        }
    }
}
