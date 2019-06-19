﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program tf = new Program();
            tf.Go();
            Console.ReadKey();

        }
        public void Go()
        {
            int side1, side2, side3;
            int input;

            do
            {
                Console.Write("-------------------------\n");
                Console.Write(" Find type of Triangle\n");
                Console.Write("-------------------------\n");
                Console.WriteLine("\n1.Enter the Triangle dimensions\n");
                Console.WriteLine("\n2.Exit \n");
              
                if ((!int.TryParse(Console.ReadLine(), out input)) || input <= 0 || input > 2)
                {
                    Console.WriteLine("Please Enter the Correct option: ");
                    continue;
                }
                    Console.Write("------------------------\n");
                //gets the input of side 1 of a triangle
                do
                {
                    Console.Write("Enter Side 1 of a triangle\n");
                    side1 = Convert.ToInt32(Console.ReadLine());
                } while (side1 <= 0);


                //gets the input of side 2 of a triangle
                do
                {
                    Console.Write("Enter Side 2 of a triangle\n");
                    side2 = Convert.ToInt32(Console.ReadLine());
                } while (side2 <= 0);

                //gets the input of side 3 of a triangle
                do
                {
                    Console.Write("Enter Side 3 of a triangle\n");
                    side3 = Convert.ToInt32(Console.ReadLine());
                } while (side3 <= 0);

                Console.WriteLine(triangleSolver.Analyze(side1, side2, side3));

            } while ( input!= 2 );
        }
        
    }
}
