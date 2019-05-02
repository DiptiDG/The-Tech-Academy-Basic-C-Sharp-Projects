using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassnObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            int power = math.Power(number);
           int addition = math.Addition(number);
            int division =math.Division(number);
            Console.WriteLine("The Given Number is " + number + "\n Power of Number is :" + power + "\n Addition" +
                "of Number is " + addition + "\n Division of Number is: " + division);
            Console.Read();


        }
    }
}
