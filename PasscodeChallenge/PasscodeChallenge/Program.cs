using System;

namespace PasscodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var code = "";

            while (code != "secret")
            {
                Console.WriteLine("What is the pass code");
                code = Console.ReadLine();

                if (code != "secret")
                {
                    Console.WriteLine("Not Authenticated");
                }
            }
            Console.WriteLine("Authenticated");

        }
    }
}
