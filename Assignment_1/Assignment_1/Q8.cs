using System;
using System.Linq;

namespace Assignment_1
{
    class Q8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int fact = 1;
            foreach(int i in Enumerable.Range(1,int.Parse(Console.ReadLine())))
            {
                fact *= i;
            }
            Console.WriteLine("Factorial is " + fact);
        }
    }
}
