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
            //DateTime yearofbirth = new DateTime(1995, 5, 6, 3, 23, 40);
            //DateTime yearofgraduation = new DateTime(2013, 3, 6, 2, 30, 52);

            //TimeSpan ageatgraduation = yearofgraduation - yearofbirth;
            Console.WriteLine("Enter a Number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number);
            Console.WriteLine("-----------------------------");
            using (StreamWriter num = new StreamWriter("C:\\Users\\Dipti\\number.txt", true))
            {
                num.WriteLine(number);
            }
            string readnum = File.ReadAllText("C:\\Users\\Dipti\\number.txt");
            Console.WriteLine(readnum);
            Console.Read();
        }
    }
}