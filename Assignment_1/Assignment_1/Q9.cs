using System;

namespace Assignment_1
{
    class Q9
    {
        static void Main(string[] args)
        {
            int former = 0, later = 1;
            while (former <= 40)
            {
                Console.Write(former + ", ");
                int  temp = former + later;
                former = later;
                later = temp;
            }
        }
    }
}
