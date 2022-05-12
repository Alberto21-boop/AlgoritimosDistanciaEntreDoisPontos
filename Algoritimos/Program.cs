using System;

namespace Algoritimos
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2;

            x1 = 12d;
            x2 = 13d;
            y1 = 11d;
            y2 = 10d;
            var distancia = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Console.WriteLine("A distancia entre os pontos é " + distancia);
        }
    }
}