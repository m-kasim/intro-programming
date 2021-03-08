using System;


namespace problem09
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

            int rectangleCoordinate01 = -1;
            int rectangleCoordinate02 = 5;
            int rectangleCoordinate03 = 1;
            int rectangleCoordinate04 = 5;

            bool pointIsWithinRectangle = false;

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

            // Check if the point lines within the rectangle
            if ((randomPointX >= rectangleCoordinate01) &&
                 (randomPointX <= rectangleCoordinate02) &&
                 (randomPointY >= rectangleCoordinate03) &&
                 (randomPointY <= rectangleCoordinate04))
            {
                pointIsWithinRectangle = true;
                Console.WriteLine("The point with coordinates ({0},{1}) lies within the rectangle", randomPointX, randomPointY);
            }
            else
            {
                Console.WriteLine("The point with coordinates ({0},{1}) DOES NOT lie within the rectangle", randomPointX, randomPointY);
            }
        }
    }
}