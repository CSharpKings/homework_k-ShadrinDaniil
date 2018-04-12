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
            int[] numbers = { 46, 0, 8, 3, 56, 6, 1, 7 };
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1]  < numbers[i])
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
