using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeJaeseung_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 1;
            int d = 0;
            while (c <= 5)
            {
                d = 0;
                do
                {
                    Console.Write("*");
                    d++;
                } while (d < c);
                Console.WriteLine();
                c++;
            }
            Console.WriteLine();

            int r = 5;
            int t = 0;

            while (r > 0)
            {
                t = r;
                do
                {
                    Console.Write("*");
                    t--;
                } while (t > 0);                
                Console.WriteLine();
                r--;
            }
        }
    }
}
