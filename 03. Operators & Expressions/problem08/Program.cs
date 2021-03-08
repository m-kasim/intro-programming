using System;

/*
- Напишете програма, която проверява дали дадена точка О (x, y) е вътре в окръжността К ((0,0), 5).
- Пояснение: точката (0,0) е център на окръжността, а радиусът й е 5.
*/
namespace problem08
{
    class Program
    {
        static void Main(string[] args)
        {
            double randomPointX = 0.0d;
            double randomPointY = 0.0d;

            double circleRadius = 5.0d;

            double sideA = 0.0d;
            double sideB = 0.0d;
            double hypotenuse = 0.0d;

            bool pointIsWithinCircle = false;


            Console.WriteLine("Determine whether a random point O(x,y) lies within circle K(0,0)");

            // Get input: Points X, Y
            Console.Write("Point X:");
            randomPointX = Convert.ToDouble(Console.ReadLine());
            Console.Write("Point Y:");
            randomPointY = Convert.ToDouble(Console.ReadLine());

            // Build right triangle sides
            sideA = randomPointX;
            sideB = randomPointY;

            hypotenuse = (randomPointX * randomPointX) + (randomPointY * randomPointY);
            hypotenuse = Math.Sqrt(hypotenuse);

            // Check if the point lies within
            if (hypotenuse <= circleRadius)
            {
                pointIsWithinCircle = true;
                Console.WriteLine("The point with coordinates ({0},{1}) lies within circle K(0,0) " +
                    "with radius {2}", randomPointX, randomPointY, circleRadius);
            }
            else
            {
                Console.WriteLine("The point with coordinates ({0},{1}) DOES NOT lie within circle K(0,0) " +
                    "with radius {2}", randomPointX, randomPointY, circleRadius);
            }

        }
    }
}
