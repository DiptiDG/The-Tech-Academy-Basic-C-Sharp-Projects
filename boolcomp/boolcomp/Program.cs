using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolcomp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter even number");
            int num = Convert.ToInt32( Console.ReadLine());
            int res = num % 2;
            bool isEven = false;

            while (!isEven)
            {
                switch (res)
                {
                    case 1:
                        Console.WriteLine("You entered  odd number. Try Again!");
                        Console.WriteLine("Enter number");
                        num = Convert.ToInt32(Console.ReadLine());
                        res = num %2;
                        break;
                    case 0:
                        Console.WriteLine("Wow! you entered even number");
                        isEven = true;
                        break;
                    default:
                        Console.WriteLine("Something went wrong");
                        Console.WriteLine("Enter number");
                        num = Convert.ToInt32(Console.ReadLine());
                        res = num % 2;
                        break;

                }
            }
                    Console.Read();

            
        }
    }
}
