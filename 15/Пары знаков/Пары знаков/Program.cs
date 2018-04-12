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
            int[] numbers = { 89, 7, -1, -2, -6, 6 };
                for (int i = 1; i < numbers.Length; i++)
                {
                    if(numbers[i - 1] > 0 && numbers[i] > 0||numbers[i - 1] < 0 && numbers[i] < 0)
                    {
                     
                        Console.WriteLine(numbers[i] + " " + numbers[i - 1]);
                        break;
                    }
                    
                }
            Console.ReadLine();


        }
    }
}
