using System;

namespace problem16
{
    class Program
    {
        static void Main(string[] args)
        {
            string binary = null;

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Replace the values of range [p] bits at position [p] with ones in position [q]");

            Console.WriteLine("Enter number:");
            long integer = Convert.ToInt64(Console.ReadLine());
            long replacedBits = integer;
            binary = Convert.ToString(integer, 2);
            Console.WriteLine("The chosen number is: {0}. Binary: {1}.", integer, binary);

            // Bit masks
            Console.WriteLine("Enter positions size [s]:");
            int positions_size = Convert.ToInt32(Console.ReadLine());
            if (positions_size < 1 || positions_size > 5)
            {
                Console.WriteLine("Position must be between [1;5].");
                return;
            }

            Console.WriteLine("Enter start position [p]:");
            int position_p_start = Convert.ToInt32(Console.ReadLine());
            int position_p_end = (position_p_start + positions_size) - 1;
            Console.WriteLine("End position of [p]:{0}", position_p_end);

            Console.WriteLine("Enter start position [q]:");
            int position_q_start = Convert.ToInt32(Console.ReadLine());
            int position_q_end = (position_q_start + positions_size) - 1;
            Console.WriteLine("End position of [q]:{0}", position_q_end);

            long[] p_bits_mask  = new long[] { 1, 1, 1, 1, 1 };
            long[] q_bits_mask  = new long[] { 1, 1, 1, 1, 1 };

            long[] p_bits       = new long[5];
            long[] p_bits_base  = new long[5];

            long[] q_bits       = new long[5];
            long[] q_bits_base  = new long[5];

            // Calculate masks
            for (int i = 0, p = position_p_start, q = position_q_start;
                    i < 5;
                    i++, p++, q++)
            {
                p_bits_mask[i] = p_bits_mask[i] << p - 1;
                q_bits_mask[i] = q_bits_mask[i] << q - 1;
                // DEBUG
                // Console.WriteLine("p_bits_mask[{0}]: {1}", i, Convert.ToString(p_bits_mask[i], 2) );
                // Console.WriteLine("q_bits_mask[{0}]: {1}", i, Convert.ToString(q_bits_mask[i], 2) );
            }

            // Display: Mask values
            Console.WriteLine("Mask values:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("[p][{0}]: {1}", i, Convert.ToString(p_bits_mask[i], 2) ); 
                Console.WriteLine("[q][{0}]: {1}", i, Convert.ToString(q_bits_mask[i], 2) );
            }

            // Get bits
            for (int i = 0, p = position_p_start, q = position_q_start;
                     i < 5;
                     i++, p++, q++)
            {
                p_bits[i] = integer & p_bits_mask[i];
                p_bits[i] = p_bits[i] >> p - 1;
                p_bits_base[i] = p_bits[i];

                q_bits[i] = integer & q_bits_mask[i];
                q_bits[i] = q_bits[i] >> q - 1;
                q_bits_base[i] = q_bits[i];
            }

            // Display: Bit values
            Console.WriteLine("Bit values:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("[p][{0}]: {1}", i, Convert.ToString(p_bits[i], 2));
                Console.WriteLine("[q][{0}]: {1}", i, Convert.ToString(q_bits[i], 2));
            }

            // Replace bits: XOR method. Source: https://levelup.gitconnected.com/3-ways-to-swap-values-without-a-temporary-variable-c5a2fbee4527?gi=ab69a1094f7f
            for (int i = 0; i < 5; i++)
            {
                p_bits[i] = p_bits[i] ^ q_bits[i];
                q_bits[i] = p_bits[i] ^ q_bits[i];
                p_bits[i] = p_bits[i] ^ q_bits[i];
            }

            // Display: Swapped bit values
            Console.WriteLine("Swapped bit values:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("[p][{0}]: {1}", i, Convert.ToString(p_bits[i], 2));
                Console.WriteLine("[q][{0}]: {1}", i, Convert.ToString(q_bits[i], 2));
            }

            // Swap the bits in the original number
            // Algorithm:
            // Use XOR for writing 0
            // USE  OR for writing 1

            // Swap first bits
            for (int i = 0, p = position_p_start;
                 p <= position_p_end;
                 i++, p++)
            {
                // CASE: Write 0
                if ( (p_bits[i] == 0) &&
                     (p_bits[i] != p_bits_base[i]) )
                {
                    replacedBits = replacedBits ^ (p_bits_mask[i]);
                }
                // CASE: Write 1
                else
                {
                    replacedBits = replacedBits | (p_bits[i] << (p - 1) );
                }
            }

            // Swap last bits
            for (int i = 0, q = position_q_start;
                 q <= position_q_end;
                 i++, q++)
            {
                // CASE: Write 0
                if ( (q_bits[i] == 0) &&
                     (q_bits[i] != q_bits_base[i]))
                {
                    replacedBits = replacedBits ^ q_bits_mask[i];
                }
                // CASE: Write 1
                else
                {
                    replacedBits = replacedBits | (q_bits[i] << (q - 1) );
                }
            }
           
            Console.WriteLine("Bit positions: _0___@@@___0_________0____@@@__", Convert.ToString(integer, 2));
            Console.WriteLine("Original bits: {0}", Convert.ToString(integer, 2));
            Console.WriteLine("Replaced bits: {0}", Convert.ToString(replacedBits, 2));
        }
    }
}