using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Triangle_Formations
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            if (!( (a + b > c) && (a + c > b) && (c + b > a)))
            {
                Console.WriteLine("Invalid Triangle.");
            }
            else
            {
                Console.WriteLine("Triangle is valid.");
                if (a*a + b*b == c*c)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                }
                else if (a * a + c * c == b * b)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                }
                else if (b * b + c * c == a * a)
                {
                    Console.WriteLine("Triangle has a right angle between sides b and c");
                }
                else
                {
                    Console.WriteLine("Triangle has no right angles");
                }
            }
        }
    }
}
