using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // For loop solution
            for(int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Fizzbuzz");
                    continue;

                }
                if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }
                if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }

        // Solution using recursion
/*        private static void RecursiveSolution(int n)
        {
            string text = "";
            if (n > 100)
                return;

            if (n % 15 == 0)
                text = "FizzBuzz";
            else if (n % 3 == 0)
                text = "Fizz";
            else if (n % 5 == 0)
                text = "Buzz";
            else
                text = n.ToString();

            Console.WriteLine(text);
            RecursiveSolution(n + 1);
        }*/
    }
}
