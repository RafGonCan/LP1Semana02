using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //User input for height
            string alt = Console.ReadLine();
            //convert input into double
            double a = Convert.ToDouble(alt);
            //User input for radius
            string raio = Console.ReadLine();
            //Convert input into double
            double r = Convert.ToDouble(raio);
            //calculate radius
            double volume = MathF.PI * Math.Pow(r,2) * a;
            //calculate area
            double area = 2 * MathF.PI * Math.Pow(r,2) + a;
            //Show results
            Console.WriteLine($"{volume:f3}");
            Console.WriteLine($"{area:f3}");
        }
    }
}
