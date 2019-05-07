using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Employee<T>//takes genric type of parameter
    {
        public int Id { get; set; }
        public List<T> things { get; set; }
        
    }
}
