using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //declare string variables
            string question, response;

            //Start of the cicle
            while (true)
            {
                //starting question
                Console.WriteLine("What is your question?");
                question = Console.ReadLine();

                //Q&A
                switch (question)
                {
                    case "Who are you?":
                        response = "The best AI you ever known!";
                        Console.WriteLine(response);
                    break;
                    case "how old are you?":
                        response = "I'm 5000 years old!!!";
                        Console.WriteLine(response);
                    break;
                    case "What is your name?":
                        response = "Jeremy";
                        Console.WriteLine(response);
                    break;
                    case "Are you smart?":
                        response = "...";
                        Console.WriteLine(response);
                    break;
                    case "EXIT":
                    break;
                    default:
                        response = "Don't understand the question...";
                        Console.WriteLine(response);
                        break;
                }

                //"exceptions"
                if (question == "You know everything?")
                {
                    response = "... NEXT!!!";
                    Console.WriteLine(response);
                    Console.ReadLine();
                }
                else if(question == "What is your story?")
                {
                    response = "I don't know... T.T";
                    Console.WriteLine(response);
                    Console.WriteLine("Can you ask me anything else?");
                    Console.ReadLine();
                }
            }
        }
    }
}
