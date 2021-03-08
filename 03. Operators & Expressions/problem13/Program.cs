using System;

/*
Дадено е число n, стойност v (v = 0 или 1) и позиция p.
Напишете поредица от операции, които да променят стойността на n,
така че битът на позиция p да има стойност v.

Пример n=35, p=5, v=0 -> n=3.

Още един пример: n=35, p=2, v=1 -> n=39.
*/
namespace problem13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integer which will be compared
            Console.WriteLine("Change the bit of a number in a certain position");

            Console.WriteLine("Enter number whose bits will be modified:");
            int integer = Convert.ToInt32(Console.ReadLine());
            // Convert to binary
            string binary_integer = Convert.ToString(integer, 2);
            Console.WriteLine("Binary of integer {0} is: {1}", integer, binary_integer);

            // Position
            Console.WriteLine("Enter position of the bit which needs to be modified:");
            int position = Convert.ToInt32(Console.ReadLine());

            // Bit value at the specified position
            Console.WriteLine("Enter the bit value (0 or 1) for the specified position:");
            byte bitValue = Convert.ToByte(Console.ReadLine());

            if ( (bitValue != 0) && (bitValue != 1) )
            {
                Console.WriteLine("ERROR: Invalid bit value selected");
                return;
            }

            int shifter = bitValue; // 00000001

            // Reduce the position by 1, because of the zeroes
            position--;

            int mask = shifter << position; // Move the 1st bit left by p positions
            string binary_mask = Convert.ToString(mask, 2);
            Console.WriteLine("Binary of the shifted integer {0} which will be used for bitwase AND comparison is: {1}", mask, binary_mask);

            // Detector: This number is use to "detect" the position of the bit which will be shifted
            int compared_number = integer & mask; // Either 0 or non-zero
            Console.WriteLine("Compared number after bitwise & (Logical AND) comparison of {0} and {1} is:", integer, compared_number);

            // First check with BITWISE OR whether the number changes
            // If it doesn't change: The user has selected as input the same bit value, as the current bit value at that position
            // So we don't need to change anything
            int numberCheckIfBitNeedsToBeChanged = integer | mask;

            if (numberCheckIfBitNeedsToBeChanged == integer)
            {
                Console.WriteLine("Bit at the position is the same! No need to be changed.");
                return;
            }
            else
            {
                Console.WriteLine("Bit at the position is NOT the same. Proceeding with change");

                // Use XOR bitwise operation in order to modify the bit
                int numberModifiedBit = integer ^ mask;
                Console.WriteLine("Modified bits number is: {0}", numberModifiedBit);
                string binary_numberModifiedBits = Convert.ToString(numberModifiedBit, 2);
                Console.WriteLine("Modified bits in binary: {0}", binary_numberModifiedBits);
            }
        }
    }
}