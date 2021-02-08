using System;

/*
Инициализирайте променлива от тип int със стойност 256 в шестнадесетичен
формат (256 е 100 в бройна система с основа 16)
*/

namespace problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberDecimal       = 256;
            int numberHexadecimal   = 0x100;

            if (numberDecimal == numberHexadecimal)
            {
                Console.WriteLine("Values are equal!");
            }
        }
    }
}
