using System;

/*
Напишете израз, който да проверява дали третата цифра (отдясно на
ляво) на дадено цяло число е 7.
*/
namespace problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer:");
            int number = Convert.ToInt32(Console.ReadLine());

            int numberHundreds = number / 100;
            int numberDecimals = numberHundreds % 10;

            Console.WriteLine("Test outcome is: {0}", numberDecimals);

            if (numberDecimals == 7)
            {
                Console.WriteLine("Yes, the third digit of the number {0} is 7.", number);
            }
            else
            {
                Console.WriteLine("No, the third digit of the number {0} is not 7.", number);
            }

        }
    }
}
