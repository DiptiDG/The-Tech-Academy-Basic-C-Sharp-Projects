using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumtype
{
    class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                  Console.WriteLine("Enter current day of the week ");
                string day = Console.ReadLine();
                Daysoftheweek week =  (Daysoftheweek)Enum.Parse(typeof(Daysoftheweek), day);
                if (week == Daysoftheweek.tuesday)
                {
                    Console.WriteLine("Today is tuesday");
                }


            }
            catch
            { Console.WriteLine("Please enter an actual day of the week."); }
            Console.Read();
        }

        public enum Daysoftheweek
        {
            monday, tuesday, wednesday, thursday, friday, saturday, sunday
        }
    }
}
