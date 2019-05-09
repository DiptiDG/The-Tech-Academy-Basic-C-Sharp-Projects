using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamnbadaexpression
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employee = new List<Employee>();
           
            employee.Add(new Employee() { firstName = "Nancy", lastName = "Williams", Id = 2 });
            employee.Add(new Employee() { firstName = "Andrew", lastName = "Harper", Id = 0 });
            employee.Add(new Employee() { firstName = "Janet", lastName = "Devis", Id = 3});
            employee.Add(new Employee() { firstName = "Joe", lastName = "Jones", Id = 1 });
            employee.Add(new Employee() { firstName = "Ria", lastName = "Kapoor", Id = 5 });
            employee.Add(new Employee() { firstName = "Daniel", lastName = "White", Id = 6 });
            employee.Add(new Employee() { firstName = "Joe", lastName = "Brown", Id = 8});
            employee.Add(new Employee() { firstName = "Mateo", lastName = "Smith", Id = 9 });
            employee.Add(new Employee() { firstName = "Aria", lastName = "Johnson", Id = 10});
            employee.Add(new Employee() { firstName = "Nina", lastName = "Scott", Id = 7 });
          
            foreach(Employee emp in employee)
            {
                Console.WriteLine("{0}\t{1}\t\t{2}", emp.firstName, emp.lastName, emp.Id);
            }
            Console.WriteLine("_____________________________________________________");
            //creating new list of emplyee with first name Joe
            List<Employee> Joe = new List<Employee>();
            foreach (Employee emp1 in employee)
            {
                if (emp1.firstName == "Joe")
                {
                    Joe.Add(emp1);

                }
            }
            foreach(Employee e in Joe)
            {
                Console.WriteLine("{0}\t{1}\t{2}", e.firstName, e.lastName, e.Id);
            }
            Console.WriteLine("__________________________________________________");
            //creating list of employee whose first name Joe by usig lambada expressions.
            List<Employee> Joe1 = employee.FindAll(x => x.firstName == "Joe").ToList();
            foreach(Employee emp2 in Joe1)
            {
                Console.WriteLine("{0}\t{1}\t{2}",emp2.firstName,emp2.lastName,emp2.Id);
            }
            Console.WriteLine("_________________________________________");
            //creating list of employye whose id > 5 by using lambada expressions.
            List<Employee> greaterId = employee.FindAll(x => x.Id > 5).ToList();
            foreach (Employee emp in greaterId)
            {
                Console.WriteLine("{0}\t{1}\t{2}", emp.firstName, emp.lastName, emp.Id);
            }

            Console.Read();



        }


    }
}