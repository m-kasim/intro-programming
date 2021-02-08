using System;

namespace _01_helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добър ден!");

            Console.WriteLine("1 \n101 \n1001");

            Console.WriteLine("1 \n101 \n1001");


            Console.WriteLine("Current date and time is: {0}", DateTime.Now);

            Console.WriteLine("Square root of 12345 is: {0}", Math.Sqrt(12345));

            Console.WriteLine("First 100 elements are:");
            int counter = 2;
            for(int i = 0; i < 100; i++)
            {
                counter--;
                Console.WriteLine("Current element is: {0}", counter);
            }

            Console.WriteLine("Please enter your current age:");
            int currentAge = 0;

            currentAge = Int32.Parse(Console.ReadLine());

            int newAgeIn10Years = currentAge + 10;

            Console.WriteLine("In 10 years you will be {0} years old.", newAgeIn10Years);
        }
    }
}