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
            Console.WriteLine("While X 2");
            int i = 1;
            int j = 0;
            while (i <= 5)
            {
                j = 1;
                while(j <= i)
                {
                    Console.Write("*");
                    j++;
                }                
                Console.WriteLine();
                i++;                
            }

            int q = 5;
            int w = 0;

            while(q > 0)
            {
                w = q;
                while(w > 0)
                {
                    Console.Write("*");
                    w--;
                }
                Console.WriteLine();
                q--;
            }

            Console.WriteLine("doWhile X 2");
            int p = 1;
            int k = 0;
            do
            {
                k = 1;
                do
                {
                    Console.Write("*");
                    k++;
                } while (k <= p);
                Console.WriteLine();
                p++;
            } while (p <= 5);

            int z = 0;
            int x = 0;
            do
            {
                x = z;
                do
                {
                    Console.Write("*");
                    x++;
                } while (x < 5);
                Console.WriteLine();
                z++;
            } while (z < 5);

            Console.WriteLine("While & doWhile");
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
