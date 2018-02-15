using System;

namespace Work2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Введи число");
                int number = int.Parse(Console.ReadLine());
                sum = sum + number;
                if (sum <= 100)
                {

                    Console.WriteLine(sum);
                }
                if ( sum > 100)
                {
                   Console.ReadLine();
                    break;

                }
            }

        }
    }
}