using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Employee:Person, IQuittable
    {
        public override void sayName()
        {
            Console.WriteLine("Name:" + firstName + " " + lastName);
        }

        public void Quit()
        {
            Console.WriteLine("WE are Quitting here");
            Console.Read();
        }
    }
}
