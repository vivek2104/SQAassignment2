using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class triangleFinder
    {
        static void Main(string[] args)
        {
            triangleFinder tf = new triangleFinder();
            tf.Go();
            Console.ReadKey();

        }
        public void Go()
        {
            int side1, side2, side3;
            string input;
            Console.Write("-------------------------\n");
            Console.Write(" Find type of Triangle\n");
            Console.Write("-------------------------");
            Console.Write("Form a Trigangle or Not\n");
            Console.Write("Yes or No \n");
            input = Console.ReadLine();
            do
            {
                Console.Write("------------------------\n");

                //gets the input of side 1 of a triangle

                Console.Write("Enter Side 1 of a triangle");
                side1 = Convert.ToInt32(Console.ReadLine());

                //gets the input of side 2 of a triangle

                Console.Write("Enter Side 2 of a triangle");
                side2 = Convert.ToInt32(Console.ReadLine());

                //gets the input of side 2 of a triangle

                Console.Write("Enter Side 3 of a triangle");
                side3 = Convert.ToInt32(Console.ReadLine());

                //finding type of triangle

                if (side1 == side2 && side2 == side3)
                {
                    Console.Write("This is a equilateral triangle!!!");
                }
                else if(side1 == side2 || side2 == side3 || side3== side1)
                {
                    Console.Write("This is a isosceles triangle");
                }
                else
                {
                    Console.Write("This is a Scalene triangle");
                }

            } while (input.ToUpper() != "Yes" && input.ToUpper() != "No");
       }

        
    }
}
