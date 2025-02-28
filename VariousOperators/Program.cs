using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Show message
            Console.WriteLine("Insere número inteiro-não negativo:");
            //User input
            string num = Console.ReadLine();
            //Convert input into byte
            byte n = Convert.ToByte(num);
            //calculations
            Console.WriteLine(n/2);
            Console.WriteLine(n<<3);
            Console.WriteLine(n^6);
            Console.WriteLine(n>10);
        }
    }
}
