using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionhandling
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> num = new List<int>() { 22, 45, 60, 84, 40, 33 };
            try
            {

                Console.WriteLine("Enter number to divide each number in list");
                float num2 = Convert.ToInt32(Console.ReadLine());
                foreach (int number in num)
                {
                    float res = number / num2;
                    Console.WriteLine(number + "divided by " + num2 + "=" + res);

                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
