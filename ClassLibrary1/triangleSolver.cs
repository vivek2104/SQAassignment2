using System;
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
            //rules for forming an triangle
            double sSide1 = side1 + side2;
            double sSide2 = side2 + side3;
            double sSide3 = side3 + side1;
            //condition to check triangle is formed or not
            if (sSide1 > side3 && sSide2 > side1 && sSide3 > side2)
            {
                //condition of equilateral triangle
                if (side1 == side2 && side2 == side3)
                {
                   return " This is a equilateral triangle!!!";
                }
                //condition of isosceles triangle
                else if (side1 == side2 || side2 == side3 || side3 == side1)
                {
                     return "This is a isosceles triangle!!!" ;
                }
                else
                {
                     return "This is a Scalene triangle!!!";
                } 
            
            }
            //if any conditions are not met
         else return "Triangle cannot be formed";
        }
    }
}
