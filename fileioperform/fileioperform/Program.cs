using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileioperform
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number);
            using (StreamWriter num = new StreamWriter("C:\\Users\\Dipti\\number.txt", true))
            {
                num.WriteLine(number);
            }
        }
    }
}