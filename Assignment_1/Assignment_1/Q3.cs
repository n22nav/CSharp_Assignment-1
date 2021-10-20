using System;

namespace Assignment_1
{
    class Q3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers");
            string[] inp = Console.ReadLine().Split();
            int num1 = int.Parse(inp[0]);
            int num2 = int.Parse(inp[1]);
            for(int i = num1+1; i<num2; i++)
            {
                Console.Write(i+"\t");
            }

        }
    }
}
