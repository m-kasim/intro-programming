using System;       

/*
Декларирайте променлива от тип char и присвоете като стойност
символа, който има Unicode код 72 (използвайте калкулатора на
Windows за да намерите шестнайсетичното представяне на 72).
*/
namespace problem05
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = '\x48';

            Console.WriteLine("Character is:{0}", symbol);
        }
    }
}
