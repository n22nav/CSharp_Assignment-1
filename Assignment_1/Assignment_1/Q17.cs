using System;

namespace Assignment_1
{
    class Q17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter second word");
            string s2 = Console.ReadLine();
            Console.WriteLine(string.Compare(s1, s2));
        }
    }
}
