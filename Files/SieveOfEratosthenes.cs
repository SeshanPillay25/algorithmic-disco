using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SieveOfEratosthenes
{
    class Program
    {
        static bool[] allNumbers;
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number 'n': ");
            var n = Convert.ToInt32(Console.ReadLine());
            var arrSize = n + 1;
            CreateArray(arrSize);
            Sieve(arrSize);
        }

        static void Sieve(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (allNumbers[i])
                {
                    for(int c = i; i * c< n; c++)
                    {
                        allNumbers[i * c] = false;
                    }
                }
            }

            var counter = 0;
            for (int i = 2; i < n; i++)
            {
                if(allNumbers[i])
                {
                    Console.Write(i + "  ");
                    counter++;
                }

                if (counter == 10)
                {
                    Console.Write("\n");
                    counter = 0;
                }
            }
        }

        static void CreateArray(int n)
        {
            allNumbers = new bool[n];

            for (int i = 0; i < n; i++)
            {
                allNumbers[i] = true;
            }
        }
    }
}
