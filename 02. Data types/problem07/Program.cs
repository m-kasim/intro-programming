using System;

/*
Декларирайте две променливи от тип string със стойности "Hello" и "World".

Декларирайте променлива от тип object.

Присвоете на тази променлива стойността, която се получава от конкатенацията на двете
стрингови променливи (добавете интервал, ако е необходимо).

Отпечатайте променливата от тип object.
*/

namespace problem07
{
    class Program
    {
        static void Main(string[] args)
        {
            string word01 = "Hello";
            string word02 = "World";

            object wholeWord = null;

            wholeWord = word01 + " " + word02;     

            Console.WriteLine("Value of the object is: {0}", wholeWord);
        }
    }
}
