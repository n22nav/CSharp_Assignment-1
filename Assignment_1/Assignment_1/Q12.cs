using System;

namespace Assignment_1
{
    class Q12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers");
            var inp = Console.ReadLine().Split();
            Console.WriteLine(Math.Max(Math.Max(int.Parse(inp[0]), int.Parse(inp[1])), int.Parse(inp[2])));
        }
    }
}
