using System;

/*
Декларирайте две променливи от тип string и им присвоете стойност
"The "use" of quotations causes difficulties." (без първите и последни
кавички).

В едната променлива използвайте quoted string, а в другата не го използвайте.
*/

namespace problem09
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "The \"use\" of quotations causes difficulties.";
            string secondString = @"The ""use"" of quotations causes difficulties.";

            Console.WriteLine("First string:{0}", firstString);
            Console.WriteLine("Second string:{0}", secondString);
        }
    }
}