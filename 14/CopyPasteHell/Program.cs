using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyPasteHell {
	class Program {
		static void Main(string[] args) {
			double[] numbers = { 765, 341, 1, -3, 0, 13, -200, 23, 44 };
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                numbers[i] = numbers[i] / 5;
            }

            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                Console.WriteLine(numbers[i]);
            }

			Console.ReadLine();
 
		}
	}

}
