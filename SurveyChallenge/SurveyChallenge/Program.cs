/*
 * Challenge: Multiple Choice Questions 
 * Create a simple three-question survey
 * Output the answers back in the console
 */
using System;

namespace SurveyChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name: ");
            var yourName = Console.ReadLine();
            Console.Write("How old are you? ");
            var yourAge = Console.ReadLine();
            Console.Write("What month were you born in? ");
            var birthMonth = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Your name is {yourName}, you are {yourAge} years old.\nAnd you are born in {birthMonth}.");
            Console.ReadKey();
        }
    }
}
