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
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine("Введи число");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Введи новое значение");
            int newValue = int.Parse(Console.ReadLine());
            numbers[number] = newValue;
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadLine();
        }
    }
}
