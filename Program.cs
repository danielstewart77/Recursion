using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFunctions
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Enter an number to see its factoral value or type q to quit");

            string input = Console.ReadLine();

            while (input != "q")
			{
				try
				{
                    int number = Convert.ToInt32(input);

                    long fact = GetFactorial(number);

                    Console.WriteLine("{0} factorial is {1}", number, fact);

                    Console.WriteLine("Enter a new number or quit");

                    input = Console.ReadLine();
                }

				catch
				{
                    Console.WriteLine("Hey, quit that! Enter a new number or q to quit!");
                    input = Console.ReadLine();
                }

            }

        }

        private static long GetFactorial(int number)
        {

            if (number == 0)

            {
                return 1;
            }

            return number * GetFactorial(number - 1);
        }
    }
}
