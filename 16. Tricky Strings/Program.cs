using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Tricky_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var delimiter = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            string result = string.Empty;
            for (int i = 0; i < n - 1; i++)
            {
                var input = Console.ReadLine();
                result += input + delimiter;
            }

            var inputEnd = Console.ReadLine();
            result += inputEnd;

            Console.WriteLine(result);
        }
    }
}
