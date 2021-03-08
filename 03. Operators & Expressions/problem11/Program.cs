using System;

/*
Дадено е число n и позиция p.

Напишете поредица от операции, които да отпечатат стойността на бита
на позиция p от числото n (0 или 1).

Пример:
n=35, p=5 -> 1.

Още един пример:
n=35, p=6 -> 0.
*/
namespace problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Show the n-th bith of a number.");

            Console.WriteLine("Enter number whose bits will be inspected:");
            int integer = Convert.ToInt32(Console.ReadLine());
            string binary_integer = Convert.ToString(integer, 2);
            Console.WriteLine("Binary of integer {0} is: {1}", integer, binary_integer);

            Console.WriteLine("Enter position of the bit which needs to be inspected:");
            int position = Convert.ToInt32(Console.ReadLine());

            int shifter = 1; // 00000001

            // Reduce the position by 1, because of the zeroes
            position--;

            int mask = shifter << position; // Move the 1st bit left by p positions
            string binary_mask = Convert.ToString(mask, 2);
            Console.WriteLine("Binary of the shifted integer {0} which will be used for bitwase AND comparison is: {1}", mask, binary_mask);

            int compared_number = integer & mask;
            Console.WriteLine("Compared number after bitwise & (Logical AND) comparison of {0} and {1} is:", integer, compared_number);

            Console.WriteLine("Bit at position is:");
            Console.WriteLine( (integer & mask) != 0 ? 1 : 0 );
        }
    }
}
