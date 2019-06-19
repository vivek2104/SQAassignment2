using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class triangleSolver
    {
        public static string Analyze(int side1, int side2, int side3)
        {
            int sSide1 = side1 + side2;
            int sSide2 = side2 + side3;
            int sSide3 = side3 + side1;

            if (sSide1 > side3 && sSide2 > side1 && sSide3 > side2)
            {
                if (side1 == side2 && side2 == side3)
                {
                    Console.Write("This is a equilateral triangle!!!");
                    return " ";
                }
                else if (side1 == side2 || side2 == side3 || side3 == side1)
                {
                    Console.Write("This is a isosceles triangle");
                    return " ";
                }
                else
                {
                    Console.Write("This is a Scalene triangle");
                    return " ";
                } 
            
            }
         else return "Triangle cannot be formed";
        }
    }
}
