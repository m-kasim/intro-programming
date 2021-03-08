using System;

namespace problem05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculate trapezoid area
            float a = 0.0f;
            float b = 0.0f;
            float h = 0.0f;
            float trapezoidArea = 0.0f;

            Console.WriteLine("In order to calculate the trapezoid's area, please enter its variables:");
            Console.WriteLine("a=");
            a = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("b=");
            b = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("h=");
            h = Convert.ToSingle(Console.ReadLine());

            // Do the calculation
            trapezoidArea = ((a + b) / 2) * h;

            Console.WriteLine("The area of the trapezoid is: {0}", trapezoidArea);
        }
    }
}
