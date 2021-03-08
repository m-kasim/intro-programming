using System;

/*
Напишете израз, който да проверява дали третият бит на дадено число
е 1 или 0

Използвайте побитово "И" върху числото и число, което има 1 само в
третия си бит (т.е. числото 8, ако броенето на битовете започне от 0).
Ако върнатият резултат е различен от 0, то третия бит е 1.
*/
namespace problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer:");
            int number = Convert.ToInt32(Console.ReadLine());

            // Show the number in binary
            Console.WriteLine("The number you entered in binary is:");
            Console.WriteLine(Convert.ToString(number, toBase: 2));

            // Do the check
            int numberCheck = 4; // Binary: 100

            // Show the number in binary
            Console.WriteLine("The number 4 in binary is:");
            Console.WriteLine(Convert.ToString(numberCheck, toBase: 2) );

            int? thirdBitIsOne = null;

            thirdBitIsOne = (number & numberCheck);

            if (thirdBitIsOne != 4)
            {
                Console.WriteLine("No, the third bit of the number {0} is not 1.", number);
            }
            else
            {
                Console.WriteLine("Yes, the third bit of the number {0} is 1.", number);
            }
        }
    }
}
