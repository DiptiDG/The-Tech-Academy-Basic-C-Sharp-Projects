using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreException
{
    class Program
    {
        static void Main(string[] args)
        {
           

          
            try {
                Console.WriteLine("What is your Age?");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                {
                    throw new Exception();
                }
                var yearborn = DateTime.Now.Year - age;
                Console.WriteLine("User born in {0}", yearborn);
               
              }


            catch (FormatException)
            {
                Console.WriteLine("An error occured. something is wrong");//error message
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Only positive number Please.");// error messagefor -ve or 0number
                Console.ReadLine();
                return;
            }
            Console.Read();
        }
    }
}
