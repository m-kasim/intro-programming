using System;

namespace problem14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check if number is prime.");

            Console.WriteLine("Enter number:");
            int integer = Convert.ToInt32(Console.ReadLine());

            int maximumPossiblePrime = integer ^ 2;

            for (int i = 2; i <= maximumPossiblePrime; i++)
            {
                if ( (integer != i) &&
                     (integer % i == 0) )
                {
                    Console.WriteLine("The number {0} is not prime number, since it is divisible by {1}", integer, i);
                    return;
                }
            }

            Console.WriteLine("The number {0} is a prime number!", integer);

        }
    }
}
