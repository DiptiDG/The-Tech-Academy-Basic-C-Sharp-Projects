using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Person per = new Person();
            emp.Id = 4;
            per.Id = 8;
            bool result = emp.Id == per.Id;
            Console.WriteLine(result);
            result = emp.Id != per.Id;
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
