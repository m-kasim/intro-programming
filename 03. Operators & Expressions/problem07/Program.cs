using System;

namespace problem07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculate the weight of a man from Earth on the Moon
            float weightOfPersonOnEarth = 0.0f;
            float weightOfPersononMoon = 0.0f;
            float weightFactorOnMoon = 0.17f;

            Console.WriteLine("CCalculate the weight of a man from Earth on the Moon.");
            Console.WriteLine("Please enter the weight of the person on Earth:");
            weightOfPersonOnEarth = Convert.ToInt32(Console.ReadLine());

            // Calculate perimeter
            weightOfPersononMoon = weightOfPersonOnEarth * weightFactorOnMoon;

            Console.WriteLine("A person who weights {0} on Earth would weight {1} on the Moon.", weightOfPersonOnEarth, weightOfPersononMoon);

        }
    }
}
