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
            int[] people = new int[12];
            Random rand = new Random();
            
            for (int i = 0; i < people.Length; i++)
            {
                int sm = rand.Next(163, 191);
                people[i] = sm;
            }
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine(people[i]);
            }

            Console.ReadLine();
        }
    }
}
