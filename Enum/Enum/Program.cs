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
 
            Console.WriteLine("Enter current day of the week ");
            try
            { 
                string day = Console.ReadLine();
                 bool res = int.TryParse(day, out int num1);
                if (res == false)
                { 
                Daysoftheweek week = (Daysoftheweek)Enum.Parse(typeof(Daysoftheweek), day);
                Console.WriteLine(week);

                    // found!
                }
                else 
                {
                    Console.WriteLine("Please enter actual day of the week");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Please enter actual day of the week");
            }
          
              
         
            Console.Read();
        }

       

        public enum Daysoftheweek
        {
            monday, tuesday, wednesday, thursday, friday, saturday, sunday
        }
    }
}
