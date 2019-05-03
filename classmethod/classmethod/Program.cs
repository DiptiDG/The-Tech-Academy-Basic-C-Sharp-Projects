using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classmethod
{
   public static class Program//declaring class static
    {
        static void Main(string[] args)
        {
           
            dividemethod div = new dividemethod();
            Console.WriteLine("Enter number");
            int x = Convert.ToInt32(Console.ReadLine());
            int y;
           // div.Division( x);
            div.Division(x, out y);
        }
    }
}
