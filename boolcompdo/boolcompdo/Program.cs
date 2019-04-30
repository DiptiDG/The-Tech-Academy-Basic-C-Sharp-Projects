using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolcompdo
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
        
            bool isEven = num == 2;


            do
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("You entered  odd number. Try Again!");
                        Console.WriteLine("Enter number");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You entered  odd number. Try Again!");
                        Console.WriteLine("Enter number");
                        num = Convert.ToInt32(Console.ReadLine());

                        break;
                    case 2:
                        Console.WriteLine("Correct! You entered Even number.");
                        isEven = true;
                        break;

                    default:
                        Console.WriteLine("Something went wrong");
                        Console.WriteLine("Enter number");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isEven);
            Console.Read();


        }
    }
}

     
