using System;

namespace Assignment_1
{
    class Q4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            var res = int.Parse(Console.ReadLine()) % 2 == 0 ? "Even number" : "Odd number";
            Console.WriteLine(res);
        }
    }
}
