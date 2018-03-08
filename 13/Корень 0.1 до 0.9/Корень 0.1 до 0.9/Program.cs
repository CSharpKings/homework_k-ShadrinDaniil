using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            for (double number = 0.1; number <= 0.9; number = number + 0.1)
            {

                Console.WriteLine("Корень" + number + "=" + Math.Sqrt(number));
            }
            Console.ReadLine();
        }
    }
}
