using System;

namespace problem06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculate the perimeter and area of an rectangle
            int sideA = 0;
            int sideB = 0;
            int rectanglePerimeter = 0;
            int rectangleArea = 0;

            Console.WriteLine("Calculate the are and perimeter of a rectangle.");

            Console.Write("A=");
            sideA = Convert.ToInt32(Console.ReadLine());

            Console.Write("B=");
            sideB = Convert.ToInt32(Console.ReadLine());

            // Calculate perimeter
            rectanglePerimeter = (2 * sideA) + (2 * sideB);

            // Calculate area
            rectangleArea = sideA * sideB;

            // Print results
            Console.WriteLine("The perimeter of the rectangle is {0}", rectanglePerimeter);
            Console.WriteLine("The area of the rectangle is {0}", rectangleArea);
        }
    }
}