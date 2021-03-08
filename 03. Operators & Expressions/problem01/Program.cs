using System;

namespace problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first integer:");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the number is an even one
            if (number % 2 == 0)
            {
                Console.WriteLine("The integer {0} is even!", number);
            }
            else
            {
                Console.WriteLine("The integer {0} is odd!", number);
            }
            
        }
    }
}
