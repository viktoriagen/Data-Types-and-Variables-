using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOne = int.Parse(Console.ReadLine());
            var indicator = Console.ReadLine();
            var numTwo = int.Parse(Console.ReadLine());


            switch (indicator)
            {
                case "+":
                    Console.WriteLine($"{numOne} {indicator} {numTwo} = " + (numOne+numTwo));
                    break;
                case "*":
                    Console.WriteLine($"{numOne} {indicator} {numTwo} = " + (numOne * numTwo));
                    break;
                case "-":
                    Console.WriteLine($"{numOne} {indicator} {numTwo} = " + (numOne - numTwo));
                    break;
                case "/":
                    Console.WriteLine($"{numOne} {indicator} {numTwo} = " + (numOne / numTwo));
                    break;
            }
        }
    }
}
