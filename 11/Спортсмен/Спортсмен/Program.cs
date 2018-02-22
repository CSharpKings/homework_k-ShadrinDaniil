using System;

namespace Спортсмен
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double sum = 0;
            double y = 30;
            double x = 10;

            double quantity = 0;
            while (true)
            {
                quantity = quantity + 1;
                double x2 = x / 100 * 10;    
                sum = x + sum;
                x = x + x2;
                if (y <= sum)
                {
                    Console.WriteLine(quantity);
                    Console.ReadLine();
                }
            }
        }
    }
}
