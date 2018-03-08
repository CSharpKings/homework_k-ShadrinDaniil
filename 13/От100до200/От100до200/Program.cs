using System;

namespace от100до200
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int number = 100; number <= 200; number++)
            {
                if (number % 7 == 0)
                {
                    Console.WriteLine(number);
                }
            }
            Console.ReadLine();


        }
    }
}
