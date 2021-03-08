using System;

// Напишете булев израз, който да проверява дали дадено цяло число се
// дели на 5 и на 7 без остатък.
namespace problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isDivisibleBy5And7 = false;

            Console.WriteLine("Please enter an integer:");
            int number = Convert.ToInt32(Console.ReadLine());

            if ( (number % 5 == 0) && (number % 7 == 0) )
            {
                isDivisibleBy5And7 = true;
            }

            Console.WriteLine("The claim that the number is divisible by 5 and 7 is: {0}",
                isDivisibleBy5And7);

        }
    }
}