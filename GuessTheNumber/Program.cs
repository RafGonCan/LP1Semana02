using System;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();
            int numberToGuess = rnd.Next(31);
            
            //Message for input
            Console.WriteLine("Insert number:");
            string number = Console.ReadLine();
            
            //Convert
            int num = Convert.ToInt32(number);

            //condition
            if (num < 0)
            {
                Console.WriteLine("Number is to low");
            }
            if (num > 30)
            {
                Console.WriteLine("Number is to high");
            }
        }
    }
}
