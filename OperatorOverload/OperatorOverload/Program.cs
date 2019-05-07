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
            emp.Id = 5;
            bool result = emp == per;//comparing object
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
