using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Programs
{
    public class Example1
    {
        public int a = 70; public int b = 80;
         
        public int getValue()
        {
            int total = a-b;
           
            return total;
            
        }
        public int getValue2(int total)
        {

            Console.WriteLine("The value of Total", total);
            return a + b;

        }

    }

}
