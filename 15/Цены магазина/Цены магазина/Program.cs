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
            int[] jule = new int[31];
            int[] august = new int[31];
            Random rand = new Random();
            int sum = 0;
            for (int i = 0; i < jule.Length; i++)
            {
                int price = rand.Next(500, 20000);
                jule[i] = price;
                sum = sum + jule[i];
            }
            for (int i = 0; i < august.Length; i++)
            {
                int price = rand.Next(500, 20000);
                august[i] = price;
                sum = sum + august[i];
            }
            Console.WriteLine(sum);

                Console.ReadLine();
        }
       
    }

}
