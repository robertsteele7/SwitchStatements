using System;

namespace SwitchStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school Subject?");
                var subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("Math is fun!");
                    break;
                case "Science":
                    Console.WriteLine("Science can be fun!");
                    break;
                case "Pottery":
                    Console.WriteLine("Pottery can be challenging");
                    break;
                case "English":
                    Console.WriteLine("English is fun and exciting");
                    break;
                case "Biology":
                    Console.WriteLine("Biology can be interesting!");
                    break;
                default:
                    Console.WriteLine("Ah I haven't taken that subject before");
                    break;
            }
        }
    }
}
