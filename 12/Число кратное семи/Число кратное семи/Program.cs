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
            for (int number = 100; number <= 200; number++)
            {
                if ( number % 7 == 0  )
                {
                    Console.WriteLine(number);
                }
            }
            Console.ReadLine();

        }
    }
}
