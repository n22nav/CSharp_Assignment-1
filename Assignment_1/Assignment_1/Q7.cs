using System;
using System.Linq;

namespace Assignment_1
{
    class Q7
    {
        static void Main(string[] args)
        {
            foreach (int i in Enumerable.Range(0,26))
            {
                Console.Write("{0}, ", i * i);
            }
        }
    }
}
