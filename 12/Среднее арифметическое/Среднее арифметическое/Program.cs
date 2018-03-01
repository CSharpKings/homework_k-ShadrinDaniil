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
            Random gen = new Random();
            
            int sum = 0;
            for (int num = 0; num <= 4; num++)
            {
                int number = gen.Next(5);
                sum = sum + number;
                
                 Console.WriteLine(number);
                    
            }
                    Console.WriteLine("Среднее число");
                    Console.WriteLine(sum / 5);
                
                
            
                    Console.ReadLine();
        }
    }
}
