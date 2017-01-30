using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var temp = 0;
            for (int i = 1; i <= n; i++)
            {
               
                    temp = i;
                    sum = 0;
                    do
                    {
                         
                        sum = sum + (temp % 10);
                        temp = temp / 10;
                    } while (temp > 0);
                    if (sum == 5 || sum == 7 || sum == 11)
                    {
                        Console.WriteLine("{0} -> True", i);
                    }
                    else
                    {
                        Console.WriteLine("{0} -> False", i);
                    }
                }
            }
    }
}


