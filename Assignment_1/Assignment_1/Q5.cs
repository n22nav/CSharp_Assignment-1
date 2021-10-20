using System;

namespace Assignment_1
{
    class Q5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers");
            string[] inp = Console.ReadLine().Split();
            int even = 0, odd = 0;
            foreach(string i in inp)
            {
                even += int.Parse(i) % 2 == 0 ? 1: 0;
                odd += int.Parse(i) % 2 == 0 ? 0 : 1;

            }
            Console.WriteLine("{0} Even numbers and {1} odd numbers", even, odd);
        }
    }
}
