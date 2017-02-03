using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string text = string.Empty;
            for (int i = 0; i < n; i++)
            {
                var asciiCode = int.Parse(Console.ReadLine());
                char character = (char)(asciiCode);
                text += character;

            }
            Console.WriteLine(text);
        }
    }
}
