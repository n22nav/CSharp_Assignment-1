using System;
using System.Linq;

namespace Assignment_1
{
    class Q14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 numbers");
            string[] st = Console.ReadLine().Split();
            int[] num = Array.ConvertAll(st, s => int.Parse(s));
            int[] arr = num.OrderByDescending(s => s).ToArray();
            Console.WriteLine("Total marks = {0}\nAverage marks = {1}\nMin marks = {2}\nMax marks = {3}",
                num.Sum(), num.Sum() / 10, num.Min(), num.Max());
            Console.Write("Desc marks = ");
            foreach(int i in arr)
            {
                Console.Write(" {0}", i);
            }
            Console.Write("\nAsc marks = ");
            foreach (int i in num.OrderBy(s => s).ToArray())
            {
                Console.Write(" {0}", i);
            }

        }
    }
}
