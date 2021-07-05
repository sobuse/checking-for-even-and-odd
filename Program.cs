using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace check1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write(" Your  Number na Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Your Number na Odd Number");
                Console.Read();
            }
        }
    }
}