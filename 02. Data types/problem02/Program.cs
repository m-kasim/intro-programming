using System;

// Problem:
// Кои от следните стойности може да се присвоят на променливи от тип
// float, double и decimal: 34.567839023; 12.345; 8923.1234857;
// 3456.091124875956542151256683467 ?

namespace problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 02:\n");

            //  34.567839023;
            float number01Float     = 34.567839023f;
            double number01Double   = 34.567839023d;
            decimal number01Decimal = 34.567839023m;

            Console.WriteLine("Number 01 in float: {0}", number01Float);
            Console.WriteLine("Number 01 in double: {0}", number01Double);
            Console.WriteLine("Number 01 in decimal: {0}\n", number01Decimal);

            //  12.345;
            float number02Float     = 12.345f;
            double number02Double   = 12.345d;
            decimal number02Decimal = 12.345m;

            Console.WriteLine("Number 02 in float: {0}", number02Float);
            Console.WriteLine("Number 02 in double: {0}", number02Double);
            Console.WriteLine("Number 02 in decimal: {0}\n", number02Decimal);

            //  8923.1234857;
            float number03Float     = 8923.1234857f;
            double number03Double   = 8923.1234857d;
            decimal number03Decimal = 8923.1234857m;

            Console.WriteLine("Number 03 in float: {0}", number03Float);
            Console.WriteLine("Number 03 in double: {0}", number03Double);
            Console.WriteLine("Number 03 in decimal: {0}\n", number03Decimal);

            //  3456.091124875956542151256683467
            //  8923.1234857;
            float number04Float     = 3456.091124875956542151256683467f;
            double number04Double   = 3456.091124875956542151256683467d;
            decimal number04Decimal = 3456.091124875956542151256683467m;

            Console.WriteLine("Number 04 in float: {0}", number04Float);
            Console.WriteLine("Number 04 in double: {0}", number04Double);
            Console.WriteLine("Number 04 in decimal: {0}\n", number04Decimal);
        }
    }
}
