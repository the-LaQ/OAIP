using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cikl1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, n, sum;
            n = 1;
            sum = 0;
            while (true)
            {
                sum += (n-1);
                a = (sum / 5);
                if (a==n)
                {
                    Console.WriteLine(n);
                    break;
                }
                else
                {
                    n++;
                    continue;
                }
            }
            

        }
    }
}
