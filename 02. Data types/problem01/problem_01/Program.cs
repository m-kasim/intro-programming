using System;

// Декларирайте няколко променливи, като изберете за всяка една найподходящия
// от типовете sbyte, byte, short, ushort, int, uint, long и
// ulong, за да им присвоите следните стойности: 52130, -115, 4825932,
// 97, -10000, 20000; 224; 970700000; 112; -44; -1000000; 1990;
// 123456789123456789.

namespace problem_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 02:");

            // 52130
            ushort number01 = 52130;

            // -115
            sbyte number02 = 115;

            // 4 825 932
            uint number03 = 4294967295u;

            // 97
            sbyte number04 = 97;

            // -10 000
            short number05 = -10000;

            // 20000
            short number06 = 20000;

            // 224
            byte number07 = 224;

            // 970 700 000
            int number08 = 970700000;

            // 112
            sbyte number09 = 112;

            // -44
            sbyte number10 = -44;

            // -1 000 000
            int number11 = -1000000;

            // 1990
            short number12 = 1990;

            // 123 456 789 123 456 789
            long number13 = 123456789123456789L;

        }
    }
}
