using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optionalparameter
{
    class optionalparameter
    {
        public int calc(int num, int time = 5)
        {
            for (int i = 1; i <=time; i++)
            {
                num = num * i;
             
            }
            return num;
        }
    }
}
