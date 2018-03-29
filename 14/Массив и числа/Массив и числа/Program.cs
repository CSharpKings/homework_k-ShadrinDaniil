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
            int[] numbers = {0, -8, 6, -15, 2};
           
            Console.WriteLine("напиши номер");
            int number = int.Parse(Console.ReadLine());
            if (numbers[number] < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }
            Console.ReadLine();


        } 
    }
}
