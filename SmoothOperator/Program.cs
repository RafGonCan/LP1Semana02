using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Show message
            Console.WriteLine("Insere número inteiro:");
            //User input
            string num = Console.ReadLine();
            //Convert input into sbyte
            sbyte n = Convert.ToSByte(num);
            //decrement
            n--;
            //show result
            Console.WriteLine(n);
            //increment
            n++;
            //show result
            Console.WriteLine(n);
        }
    }
}
