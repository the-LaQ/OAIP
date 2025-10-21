using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cikl4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, n, n_fact, r_fact, y, x;
            a = Convert.ToInt32(Console.ReadLine());
            n = 1;
            while (true)
            {
                y = n;
                n_fact = 1;
                while (y != 0)
                {
                    n_fact = n_fact * y;
                    y -= 1;
                }
                r_fact = 1;
                x = n + 1;
                while (x != 0)
                {
                    r_fact = r_fact * x;
                    x -= 1;
                }

                Console.WriteLine($"n={n}, n!={n_fact}, (n+1)!={r_fact}");

                if ((n_fact <= a) && (r_fact >= a))
                {
                    Console.WriteLine(n);
                    break;
                }
                else
                {
                    n++;
                    if (n > 20)
                    {
                        Console.WriteLine("Not found");
                        break;
                    }
                    continue;
                }
            }
        }
    }
}
