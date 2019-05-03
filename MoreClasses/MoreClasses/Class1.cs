using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreClasses
{
    class Class1
    {
        public int Operation (int a)
        {
                a = a * 2;
           
            return a;
         
        }
        public int Operation(decimal a)
        {
            a = a / 2;

            return Convert.ToInt32(a);

        }
        public int Operation(string s)
        {
            int a = 2;
          
            return Convert.ToInt32(s) +a ;
       

        }
    }
}
