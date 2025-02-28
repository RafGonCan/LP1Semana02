using System;
using System.Globalization;
using System.Text.Json.Serialization.Metadata;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();
            int numberToGuess = rnd.Next(31);
            
            int tries = 0;
            
            //Message for input
            Console.WriteLine("Insert number:");
            string number = Console.ReadLine();

            //Convert
            int num = Convert.ToInt32(number);

            while (num != numberToGuess)
            {
            tries++;

                //condition
                if (num < 0 || num > 30)
                {
                    Console.WriteLine("Number must be between 0 and 30. Try again");
                    break;
                }
                
                if (num < numberToGuess)
                {
                    Console.WriteLine($"The hidden number is lower than {num}. Try again");
                    break;
                }

                if (num > numberToGuess)
                {
                    Console.WriteLine($"The hidden number is higher than {num}. Try again");
                    break;
                }

                if (num == numberToGuess)
                {
                    Console.WriteLine($"You found the hidden number {numberToGuess} after {tries} tries");
                    break;
                }
            }
        }
    }
}
