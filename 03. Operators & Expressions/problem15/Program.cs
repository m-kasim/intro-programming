using System;

/*
Напишете програма, която разменя стойностите на битовете на позиции 3, 4 и 5 
с битовете на позиции 24, 25 и 26 на дадено цяло положително число. 
*/
namespace problem15
{
    class Program
    {
        static void Main(string[] args)
        {
            string binary = null;

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Replace the values of bits at positions 3, 4, 5 and with the values of the bits at positions 24, 25, 26");

            Console.WriteLine("Enter number:");
            long integer = Convert.ToInt64(Console.ReadLine());
            long replacedBits = integer;
            binary = Convert.ToString(integer, 2);
            Console.WriteLine("The chosen number is: {0}. Binary: {1}.", integer, binary);

            // Bit masks
            long bit3_mask = 4;  //   0100
            long bit4_mask = 8;  //   1000
            long bit5_mask = 16; // 1 0000

            long bit24_mask = 0b100000000000000000000000;   //   0100
            long bit25_mask = 0b1000000000000000000000000;  //   1000
            long bit26_mask = 0b10000000000000000000000000; // 1 0000

            // Get bits [3][4][5]
            long bit3 = (integer & bit3_mask) >> 2;
            long bit4 = (integer & bit4_mask) >> 3;
            long bit5 = (integer & bit5_mask) >> 4;
            long bit3_base = bit3;
            long bit4_base = bit4;
            long bit5_base = bit5;

            // Check bits [24][25][26]
            long bit24 = (integer & bit24_mask) >> 23;
            long bit25 = (integer & bit25_mask) >> 24;
            long bit26 = (integer & bit26_mask) >> 25;
            long bit24_base = bit24;
            long bit25_base = bit25;
            long bit26_base = bit26;

            // Display bits [3][4][5]
            Console.WriteLine("Original bits:");
            Console.WriteLine( "Bit [3]:  {0}", Convert.ToString(bit3, 2) );
            Console.WriteLine( "Bit [4]:  {0}", Convert.ToString(bit4, 2) );
            Console.WriteLine( "Bit [5]:  {0}", Convert.ToString(bit5, 2) );
            // Display bits [24][25][26]
            Console.WriteLine( "Bit [24]: {0}", Convert.ToString(bit24, 2) );
            Console.WriteLine( "Bit [25]: {0}", Convert.ToString(bit25, 2) );
            Console.WriteLine( "Bit [26]: {0}", Convert.ToString(bit26, 2) );

            // Replace bits: XOR method. Source: https://levelup.gitconnected.com/3-ways-to-swap-values-without-a-temporary-variable-c5a2fbee4527?gi=ab69a1094f7f
            bit3    = bit3 ^ bit24;
            bit24   = bit3 ^ bit24;
            bit3    = bit3 ^ bit24;

            bit4    = bit4 ^ bit25;
            bit25   = bit4 ^ bit25;
            bit4    = bit4 ^ bit25;

            bit5    = bit5 ^ bit26;
            bit26   = bit5 ^ bit26;
            bit5    = bit5 ^ bit26;

            // Display swapped bits
            Console.WriteLine("Swapped bits:");
            Console.WriteLine("Bit [3]:  {0}", Convert.ToString(bit3, 2));
            Console.WriteLine("Bit [4]:  {0}", Convert.ToString(bit4, 2));
            Console.WriteLine("Bit [5]:  {0}", Convert.ToString(bit5, 2));
            Console.WriteLine("Bit [24]: {0}", Convert.ToString(bit24, 2));
            Console.WriteLine("Bit [25]: {0}", Convert.ToString(bit25, 2));
            Console.WriteLine("Bit [26]: {0}", Convert.ToString(bit26, 2));

            // Swap the bits in the original number
            // Algorithm: First use AND on the initial number and then use OR on the intermediary result
            // This is used, in order to factor the 0, otherwise only OR misses the 0 cases
            if ( (bit3 == 0) && (bit3 != bit3_base) )
            {
                replacedBits = replacedBits ^ bit3_mask;
                Console.WriteLine("Case 0");
            }
            else
            {
                replacedBits = replacedBits | (bit3 << 2);
                Console.WriteLine("Case !0");
            }
            Console.WriteLine("Swap 3: {0}", Convert.ToString(replacedBits, 2));

            if ( (bit4 == 0) && (bit4 != bit4_base) )
            {
                replacedBits = replacedBits ^ bit4_mask;
                Console.WriteLine("Case 0");
            }
            else
            {
                replacedBits = replacedBits | (bit4 << 3);
                Console.WriteLine("Case !0");
            }
            Console.WriteLine("Swap 4: {0}", Convert.ToString(replacedBits, 2));

            if ( (bit5 == 0) && (bit5 != bit5_base) )
            {
                replacedBits = replacedBits ^ bit5_mask;
            }
            else
            {
                replacedBits = replacedBits | (bit5 << 4);
            }
            Console.WriteLine("Swap 5: {0}", Convert.ToString(replacedBits, 2));

            if ( (bit24 == 0) && (bit24 != bit24_base) )
            {
                replacedBits = replacedBits ^ bit24_mask;
            }
            else
            {
                replacedBits = replacedBits | (bit24 << 23);
            }
            Console.WriteLine("Swap 24: {0}", Convert.ToString(replacedBits, 2));

            if ( (bit25 == 0) && (bit25 != bit25_base) )
            {
                replacedBits = replacedBits ^ bit25_mask;;
            }
            else
            {
                replacedBits = replacedBits | (bit25 << 24);
            }
            Console.WriteLine("Swap 25: {0}", Convert.ToString(replacedBits, 2));

            if ( (bit26 == 0) && (bit26 != bit26_base) )
            {
                replacedBits = replacedBits ^ bit26_mask;
            }
            else
            {
                replacedBits = replacedBits | (bit26 << 25);
  
            }

            Console.WriteLine("Swap 26: {0}", Convert.ToString(replacedBits, 2));

            Console.WriteLine("Bit positions: _0___@@@___0_________0____@@@__", Convert.ToString(integer, 2));
            Console.WriteLine("Original bits: {0}", Convert.ToString(integer, 2));
            Console.WriteLine("Replaced bits: {0}", Convert.ToString(replacedBits, 2));
        }
    }
}
