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
            int[] numbers = new int[17];
            int number = 60;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = number;
                
                number  = number - 3;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadLine();
            
        }
    }

}
