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
          
              if( Enum.IsDefined(typeof(Daysoftheweek), week))

                {
                    Console.WriteLine(week);

                    // found!
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
            }
            catch(System.ArgumentException)
            {
                Console.WriteLine("This is not actual day");
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
