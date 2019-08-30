using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int Fizz = 3;
            int Buzz = 5;
            int FizzBuzz = 15;

            int[] FizzBuzzArray = new int[101];
            for (int i = 1; i < FizzBuzzArray.Length; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    FizzBuzz = 15;
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    Fizz = 3;
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    Buzz = 5;
                }

                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
