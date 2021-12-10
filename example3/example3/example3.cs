using System;

namespace example3
{
    class example3
    {
        
            static double Dist(double x1, double y1, double x2, double y2)
            {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            }
        static void Main(string[] args)
        {
            double x1 = 6.87;
            double y1 = 8.9;
            double x2 = 4.6;
            double y2 = 7.65;

            double dist = Dist(x1, y1, x2, y2);
            Console.WriteLine("расстояние = ", dist);
            Console.ReadKey();
        }
    }
}
