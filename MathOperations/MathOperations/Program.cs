using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MultiPlication Operation");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Enter  Number");
            int mul = Convert.ToInt32(Console.ReadLine() )* 50;
            Console.WriteLine("The multiplication result is: " +mul);

            Console.WriteLine("Addition Operation");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Enter  Number");
            int add = Convert.ToInt32(Console.ReadLine())+ 25;
            Console.WriteLine("The addition result is: " +add);

            Console.WriteLine("Division Operation");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Enter  Number");
            double div = Convert.ToInt32(Console.ReadLine()) / 12.5;
            Console.WriteLine("The division result is: " +div);

            Console.WriteLine("Boolean Operation");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Enter  Number");
           bool res = Convert.ToInt32(Console.ReadLine()) > 50;
            Console.WriteLine("The boolean result is: " +res);

            Console.WriteLine("Modulus Operation");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Enter  Number");
            double rem = Convert.ToDouble(Console.ReadLine()) % 7.0;
            Console.WriteLine("The remainder is: " +rem);
            Console.Read();
        }
    }
}
