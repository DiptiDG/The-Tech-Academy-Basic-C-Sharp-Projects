using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constword
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Subject = "Physics";//using const keyword.
           Class1 cl = new Class1("Dipti");
            var marksforsub = cl.Marks;//using vr keyword
            Console.WriteLine("marks of student is {0} for subject {1}", marksforsub, Subject);
            Console.Read();
        }
    }
}
