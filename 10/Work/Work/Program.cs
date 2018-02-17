using System;
using System.Threading;

namespace Work
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            


            int maximum = 0;
            while (true)
                
                {
                Console.WriteLine("Введи число");

                int number = int.Parse(Console.ReadLine());    




                   
               
                if (maximum < number)
                {


                    Thread.Sleep(1000);
                    maximum = 0 + number ;


                }

                Console.WriteLine("Maximum =");Console.WriteLine(maximum);  

                }
                 
            } 
        }
    }

