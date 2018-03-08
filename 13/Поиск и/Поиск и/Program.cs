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
            string str = Console.ReadLine();
            for( int n = 0; n < str.Length; n++)
            {
                if (str[n] == 'и')
                { 
                    Console.WriteLine("Да");
                }
               
            }
             Console.ReadLine();
        }
    }
}
