using System;
using System.Linq;

namespace Assignment_1
{
    class Q11
    {
        static void Main(string[] args)
        {
            foreach(int i in Enumerable.Range(200,100))
            {
                if (i % 7 != 0)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
