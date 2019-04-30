using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringoperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your FirstName");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter your LastName");
            string lname = Console.ReadLine();
            //string concatenation
            Console.WriteLine("Your name is :" + fname + " " + lname);
            //String convert to uppercase
            string up = fname.ToUpper();
            Console.WriteLine("----------------------");
            Console.WriteLine("Uppercase of your name : \n"+up);
            //stringbuilder
            StringBuilder paragraph = new StringBuilder();
            paragraph.Append("The first Line of the Text");
            paragraph.AppendLine();
            paragraph.Append("The second Line of the Text");
            Console.WriteLine(paragraph);
            Console.Read();

        }
    }
}
