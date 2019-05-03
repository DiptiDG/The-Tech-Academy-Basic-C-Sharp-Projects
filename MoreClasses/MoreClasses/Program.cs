using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            // create object here for class and using method from that class by passing value.
           int result = class1.Operation(12);
            Console.WriteLine("The ouput for this operation is "+result);
            int result1 = class1.Operation(10.05m);
            Console.WriteLine("The ouput for this operation is " + result1);
            int result2 = class1.Operation("1034");
            Console.WriteLine("The ouput for this operation is " + result2);
            Console.Read();
        }
    }
}
