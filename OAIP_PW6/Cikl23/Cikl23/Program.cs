using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cikl23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, a, b, c, sum, max, div, d;
            x = 100;
            max = 0;
            do
            {
                a = x % 10;
                b = (x / 10) % 10;
                c = (x / 10) / 10;
                sum = a + b + c;
                div = x / sum;
                if (div > max)
                {
                    max = div;
                    x++;
                }
                else x++; ;
            }
            while (x < 1000);
            Console.WriteLine(max);
        }
    }
}
