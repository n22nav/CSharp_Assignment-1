using System;
using System.Linq;
namespace Assignment_1
{
    class Q18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the word");
            string s = Console.ReadLine();
            int res = string.Compare(s, new string(s.Reverse().ToArray()));
            if (res == -1)
            {
                Console.WriteLine("Not Palindrome");
            }
            else
                Console.WriteLine("Palindrome");
        }
    }
}
