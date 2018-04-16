using System;

namespace LoopCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 1;
            while (count <= 5)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine($"========{count}============");
                for (int k = 10; k > 0; k--)
                {
                    Console.WriteLine(k);
                }
                Console.WriteLine($"========{count}============");
                count++;
            }
            
        }
    }
}
