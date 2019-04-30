using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate");
            int rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week");
            byte hour = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate");
            int rate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week");
            byte hour1 = Convert.ToByte(Console.ReadLine());

            double annualsalary = 52.14 * rate * hour;
            Console.WriteLine("Annual Salary for person 1 is: " + annualsalary);
            double annualsalary1 = 52.14 * rate1 * hour1;
            Console.WriteLine("Annual Salary for person 2 is: " + annualsalary1);

            bool person1makesmoremoney = annualsalary > annualsalary1;
            Console.WriteLine("Is Person 1 makes more money than person 2 ");
            Console.WriteLine(person1makesmoremoney);
            Console.Read();
        }
    }
}
