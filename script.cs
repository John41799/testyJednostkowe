using System;
namespace QuadraticEquation
{
    class QuadraticEquation
    {
        public static void Main()
        {
            double a = 1;
            double b = 2;
            double c = 1;

            double delta = b * b - 4 * a * c;
            Console.WriteLine(delta);

           if (delta < 0)
            {
                Console.WriteLine("no roots");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("x: ");
                Console.WriteLine(x);

            }
            else
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x1: ");
                Console.WriteLine(x1); 
                Console.WriteLine("x2: ");
                Console.WriteLine(x2);

            }
            
    }
    }
}