using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optionalparameter
{
    class Program
    {
        static void Main(string[] args)
        {
            optionalparameter optional = new optionalparameter();
            Console.WriteLine("Enter number 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2\t You may not need to enter this number");
            
            Console.WriteLine("----------------------");
            int res = optional.calc(num1);//adding only one parameter here
            Console.WriteLine(res);
            int res1 = optional.calc(num1, 4);// adding two params here
            Console.WriteLine(res1);
            
            Console.Read();
        }
    }
}
