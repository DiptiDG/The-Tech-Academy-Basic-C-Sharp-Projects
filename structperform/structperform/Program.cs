using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structperform
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number();
            num.Amount = 1000;
            Console.WriteLine(num.Amount);
            Console.Read();
        }
    }
}
