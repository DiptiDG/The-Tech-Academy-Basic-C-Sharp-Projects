using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[] { "Diana", "Elinor", "Coddar", "Saanvi", "Lucas" };


            Console.WriteLine("Select Index for stringArray");
            int index = Convert.ToInt16(Console.ReadLine());
            if (index < stringArray.Length)
            {
                Console.WriteLine(stringArray[index]);
            }
            else
                Console.WriteLine("this index doesnt exist");
            int[] intArray = new int[] { 2, 4, 6, 88, 34, 56, 77 };
            Console.WriteLine("Select Index for intArray");
            int index1 = Convert.ToInt16(Console.ReadLine());
            if (index < intArray.Length)
            {
                Console.WriteLine(intArray[index]);
            }
            else
                Console.WriteLine("this index doesnt exitst");

            List<string> stringlist = new List<string>()  { "Gole", "webber", "Smith"};
           
            Console.WriteLine("Select Index for stringlist");
            int index2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(stringlist[index2]);



            Console.Read();
        }
    }
}
