using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate an Employee object with type "string" as its generic parameter
            Employee<string> emp = new Employee<string>() ;
            emp.things = new List<string>() { "Cycle", "Bus", "Toys", "Pen" };
            for(int i =0; i<emp.things.Count; i++)
            {
                Console.WriteLine(emp.things[i]);

            }

           //Instantiate an Employee object with type "int" as its generic parameter
            Employee<int> emp1 = new Employee<int>();
            emp1.things = new List<int> { 1, 4, 8, 10 };
            for (int i = 0; i < emp1.things.Count; i++)
            {
                Console.WriteLine(emp1.things[i]);

            }
            Console.Read();

            //emp1.things.Add(4);
            //emp1.things.Add(8);
        }
    }
}
