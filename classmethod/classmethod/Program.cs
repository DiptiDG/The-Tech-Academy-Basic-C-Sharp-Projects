using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classmethod
{
   class Program
    {
        static void Main(string[] args)
        {
           
          
            Console.WriteLine("Enter number");
            int x = Convert.ToInt32(Console.ReadLine());
            int y;
           dividemethod.Division( x);
            dividemethod.Division(x, out y);
        }
    }
}
