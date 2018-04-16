using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            var yourName = Console.ReadLine();
            Console.WriteLine($"Your name is {yourName}"); // interpolated String
            Console.ReadKey();
        }
    }
}
