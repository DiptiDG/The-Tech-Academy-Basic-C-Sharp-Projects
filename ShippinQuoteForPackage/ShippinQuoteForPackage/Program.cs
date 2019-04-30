using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippinQuoteForPackage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Enter Package weight");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else if (weight < 50)
            {
                Console.WriteLine("Enter Package width");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Package height");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Package length");
                int length = Convert.ToInt32(Console.ReadLine());

                double sum = width + length + height;
                if (sum > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");

                }
                else
                {
                    double quote = (sum * weight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: " + "$" + quote);
                    Console.WriteLine("Thank You!");
                    Console.Read();
                }
            }
            else {
                Console.WriteLine("Something wrong");
                  }

            }
        }
   }

