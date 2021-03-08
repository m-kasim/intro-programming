using System;

/*
Напишете програма, която приема за вход четирицифрено число във
формат abcd (например числото 2011) и след това извършва следните
действия върху него:

- Пресмята сбора от цифрите на числото (за нашия пример 2+0+1+1= 4).

- Разпечатва на конзолата цифрите в обратен ред: dcba (за нашия пример резултатът е 1102).

- Поставя последната цифра на първо място: dabc (за нашия пример резултатът е 1201).

- Разменя мястото на втората и третата цифра: acbd (за нашия пример резултатът е 2101).
*/

namespace problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer:");
            int integer = Convert.ToInt32(Console.ReadLine());

            // Store digits permanently
            int digit01Base = 0;
            int digit02Base = 0;
            int digit03Base = 0;
            int digit04Base = 0;

            int digit01 = 0;
            int digit02 = 0;
            int digit03 = 0;
            int digit04 = 0;

            digit01 = digit01Base = integer % 10;
            Console.WriteLine("digit01: {0}", digit01);

            digit02 = digit02Base = (integer/10) % 10;
            Console.WriteLine("digit02: {0}", digit02);

            digit03 = digit03Base = (integer / 100) % 10;
            Console.WriteLine("digit03: {0}", digit03);

            digit04 = digit04Base = (integer / 1000) % 10;

            int placeholder = 0;

            // Task 1: Get the sum of all 4 digits
            int sumOfAllFourDigits = digit01 + digit02 + digit03 + digit04;
            Console.WriteLine("Sum of all 4 digits is: {0}", sumOfAllFourDigits);

            // Task 2: Print the digits in reverse order;
            placeholder = digit04;

            digit04 = digit01;
            digit01 = placeholder;

            placeholder = digit03;
            digit03 = digit02;
            digit02 = placeholder;

            Console.WriteLine("Printing all 4 digits in reverse order:");
            Console.Write(digit04);
            Console.Write(digit03);
            Console.Write(digit02);
            Console.Write(digit01);
            Console.Write("\n");

            // Task 3: Put the last number as first:
            Console.WriteLine("Put the last digit as first:");
            digit01 = digit01Base;
            digit02 = digit02Base;
            digit03 = digit03Base;
            digit04 = digit04Base;

            placeholder = digit01;           
            digit01 = digit04;
            digit04 = placeholder;

            Console.Write(digit04);
            Console.Write(digit03);
            Console.Write(digit02);
            Console.Write(digit01);
            Console.Write("\n");

            // Task 4: Change the place of second and third digits
            Console.WriteLine("Change the place of second and third digits:");
            digit01 = digit01Base;
            digit02 = digit02Base;
            digit03 = digit03Base;
            digit04 = digit04Base;

            placeholder = digit03;
            digit03 = digit02;
            digit02= placeholder;

            Console.Write(digit04);
            Console.Write(digit03);
            Console.Write(digit02);
            Console.Write(digit01);
            Console.Write("\n");
        }
    }
}