﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classmethod
{
    class dividemethod
    {
        public  void Division( int a)// creating method that takeinput from user and return number/2;
        {
           a = a / 2;
            Console.WriteLine(a);
            Console.WriteLine("The output is :"+a);
            Console.Read();


        }
        //Creating  method with output parameters.
        public void Division(int a, out int b)//overloading method
        {
            b = a / 2;
            Console.WriteLine("output :"+b);
        }

    }
}
