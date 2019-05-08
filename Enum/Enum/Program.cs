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
            string day = Console.ReadLine();
            try
            { 
            Daysoftheweek week = (Daysoftheweek)Enum.Parse(typeof(Daysoftheweek), day);

         
                if ( Enum.IsDefined(typeof(Daysoftheweek), week))

                {
                    Console.WriteLine(week);

                    // found!
                }
               
            }
          
            catch(System.ArgumentException)
            {
                Console.WriteLine("Please enter actual day of the week");
                // utilName is not an actual Utils name
            }
         
            Console.Read();
        }

       

        public enum Daysoftheweek
        {
            monday, tuesday, wednesday, thursday, friday, saturday, sunday
        }
    }
}
