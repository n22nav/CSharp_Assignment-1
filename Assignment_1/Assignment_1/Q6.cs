using System;

namespace Assignment_1
{
    class Q6

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temp in F");
            Console.WriteLine("Temp in C is {0}", (int.Parse(Console.ReadLine()) - 32) * 5 / 9);
        }
    }
}
