using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Programs
{
    public class Swaping
    {
        public int a = 10;
        public int b = 20;

       public void ReadSwap()
        {
            a=a+b;
            b=a-b;
            a=a-b;
            Console.WriteLine("b = "+b);

        }
    }
}
