﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable IQ = new Employee();//using plymorphism creating instance of interface IQuittable
            IQ.Quit();
            //Employee emp = new Employee();//creating object of class employee
            //emp.firstName = "Sample";
            //emp.lastName ="Student";
            //emp.sayName();//calling sayName method
            //Console.Read();
        }
    }
}
