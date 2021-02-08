using System;

// Напишете програма, която изчислява вярно променливи с плаваща
// запетая с точност до 0.000001.
namespace problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 01:");
            decimal input01 = Decimal.Parse( Console.ReadLine() );

            Console.WriteLine("Enter number 02:");
            decimal input02 = Decimal.Parse(Console.ReadLine());

            decimal sumOfBothNumbers = input01 + input02;
            float sumWithReducedPrecision = Convert.ToSingle(sumOfBothNumbers);

            Console.WriteLine("Sum of both numbers is: {0}", sumOfBothNumbers);

        }
    }
}
