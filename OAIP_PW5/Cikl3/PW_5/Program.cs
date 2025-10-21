using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double a, S;
            string reply;
            int i;
            reply = "1";
            while (reply == "1")
            {
                a = Convert.ToDouble(Console.ReadLine());
                if (a < 0)
                {
                    i = 3;
                    S = 0;
                    while (i <= 9)
                    {
                        S = S + (i - 2);
                        i += 2;
                    }
                }
                else
                {
                    i = 2;
                    S = 1;
                    while (i <= 8)
                    {
                        S = S * (i * i - a);  
                        i += 2;
                    }
                }
                Console.WriteLine(S);
                Console.WriteLine("Если хотите перезапустить программу нажмите 1, если закончить пишите что угодно");
                reply = Console.ReadLine();
                Console.WriteLine("Конец программы");
                Console.WriteLine("Перезапуск");
            }
        }
    }
}