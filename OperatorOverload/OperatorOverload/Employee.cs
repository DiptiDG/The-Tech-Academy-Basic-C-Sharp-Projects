using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    public class Employee : Person

    {
        public new int Id { get; set; }

        public static bool operator ==  (Employee employee, Person person)
        {
            
            return true;

        }
        public static bool operator !=(Employee employee, Person person)
        {
            
            return true;

        }


    }
}
