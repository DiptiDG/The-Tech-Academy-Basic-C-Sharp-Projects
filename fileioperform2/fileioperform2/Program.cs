using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileioperform2
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine(DateTime.Now);
           Console.WriteLine("enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DateTime.Now.AddHours(number));
           
            Console.Read();
            }
            
        }
    }
