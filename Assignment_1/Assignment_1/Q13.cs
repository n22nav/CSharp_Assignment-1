using System;
using System.Linq;

namespace Assignment_1
{
    class Q13
    {
        static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split();
            int[] arr = Array.ConvertAll(st, x => int.Parse(x));
            Console.WriteLine(Math.Min(Math.Min(Math.Min(Math.Min(arr[0], arr[1]), arr[2]), arr[3]), arr[4]));
        }
    }
}
