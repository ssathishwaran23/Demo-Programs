using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Programs
{
    public class Calculator
    {
        public int tamil = 94;
        public int english = 59;
        

        public int add()
        {
            int total = tamil + english;
            return total;

    }
        public void substract(int total   ) 
        {
            total=total-20;
            Console.WriteLine(total);
        
        }


    }
}
