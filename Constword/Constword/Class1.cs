using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constword
{
   public  class Class1
    {
      //Chaining two constructor together
        public Class1(string student) : this(60, student)
        {

        }
        public Class1(int marks, string name)
        {
            Marks = marks;
            StudentName = name;
           
        }
        public int Marks { get; set; }
        public string StudentName { get; set; }
    }
}
