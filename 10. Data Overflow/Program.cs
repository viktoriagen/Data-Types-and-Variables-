using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Data_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var firtsNum = ulong.Parse(Console.ReadLine());
            var secondNum = ulong.Parse(Console.ReadLine());
            ulong lowerNum = Math.Min(firtsNum, secondNum);
            ulong biggerNum = Math.Max(firtsNum, secondNum);

            if (biggerNum >= byte.MinValue && biggerNum <= byte.MaxValue)
            {
                Console.WriteLine("bigger type: byte");
            }
            else if (biggerNum >= ushort.MinValue && biggerNum <= ushort.MaxValue)
            {
                Console.WriteLine("bigger type: ushort");
            }
            else if (biggerNum >= uint.MinValue && biggerNum <= uint.MaxValue)
            {
                Console.WriteLine("bigger type: uint");
            }
            else if (biggerNum >= ulong.MinValue && biggerNum <= ulong.MaxValue)
            {
                Console.WriteLine("bigger type: ulong");
            }
            //lower
            string type = "";
            if (lowerNum >= byte.MinValue && lowerNum <= byte.MaxValue)
            {
                Console.WriteLine("smaller type: byte");
                type = "byte";
            }
            else if (lowerNum >= ushort.MinValue && lowerNum <= ushort.MaxValue)
            {
                Console.WriteLine("smaller type: ushort");
                type = "ushort";
            }
            else if (lowerNum >= uint.MinValue && lowerNum <= uint.MaxValue)
            {
                Console.WriteLine("smaller type: uint");
                type = "uint";
            }
            else if (lowerNum >= ulong.MinValue && lowerNum <= ulong.MaxValue)
            {
                Console.WriteLine("smaller type: ulong");
                type = "ulong";
            }
            // type
            if (type == "byte")
            {
                var times = (Math.Round(biggerNum /(double)byte.MaxValue));
                Console.WriteLine($"{biggerNum} can overflow {type} {times} times");

            }
            else if (type == "ushort")
            {
                var times = (Math.Round(biggerNum / (double)ushort.MaxValue));
                Console.WriteLine($"{biggerNum} can overflow {type} {times} times");
            }
            else if (type == "uint")
            {
                var times = (Math.Round(biggerNum / (double)uint.MaxValue));
                Console.WriteLine($"{biggerNum} can overflow {type} {times} times");
            }
           else if (type == "ulong")
            {
                var times = (Math.Round(biggerNum / (double)ulong.MaxValue));
                Console.WriteLine($"{biggerNum} can overflow {type} {times} times");
            }
            
        }
    }
}
