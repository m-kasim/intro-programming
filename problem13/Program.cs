using System;

/*
Декларирайте две променливи от тип int. Задайте им стойности
съответно 5 и 10. Разменете стойностите им и ги отпечатайте
*/
namespace problem13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("Original variables: A: {0}, B: {1}", a, b);
            b = b - a;
            a = a + b;

            Console.WriteLine("Swapped variables: A: {0}, B: {1}", a, b);

        }
    }
}
