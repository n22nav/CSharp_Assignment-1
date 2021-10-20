using System;
using System.Linq;

namespace Assignment_1
{
    class Q10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number: ");
            int inp = int.Parse(Console.ReadLine());
            foreach(int i in Enumerable.Range(1,20))
            {
                Console.WriteLine(i * inp);
            }
        }
    }
}
