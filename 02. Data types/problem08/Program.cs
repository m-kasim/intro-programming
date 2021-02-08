using System;

/*
Декларирайте две променливи от тип string и им присвоете стойности "Hello" и "World".

Декларирайте променлива от тип object и и присвоете стойността на конкатенацията на двете
променливи от тип string (не изпускайте интервала по средата).

Декларирайте трета променлива от тип string и я инициализирайте със стойността напроменливата от тип
object ( трябва да използвате type casting).
*/
namespace problem08
{
    class Program
    {
        static void Main(string[] args)
        {
            string word01 = "Hello";
            string word02 = "World";

            object wholeWord = word01 + " " + word02;

            string finalWord = (string)wholeWord;

            Console.WriteLine("Value of final typecasted string is: {0}", finalWord);
        }
    }
}
