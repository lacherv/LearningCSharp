using System;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = TryAnswer();

            Console.WriteLine("What is your age?");
            var age = TryAnswer();

            Console.WriteLine("What month were you born in?");
            var month = TryAnswer(); 

            Console.WriteLine("Your name is : {0}", name); // place holder
            Console.WriteLine("Your age is : {0}", age); // place holder
            Console.WriteLine("Your birth month is : {0}", month); // place holder

            if (month == "march")
            {
                Console.WriteLine("You are an Aries");
            }
            else if (month == "april")
            {
                Console.WriteLine("You are a Taurus");
            }
            else if (month == "may")
            {
                Console.WriteLine("You are a Gemini");
            }
        }

        static string TryAnswer()
        {
            var answer = Console.ReadLine();
            if (answer == "")
            {
                Console.WriteLine("You didn't type anything, please try again.");
                return Console.ReadLine();
            }
            return answer;
        }
    }
}
