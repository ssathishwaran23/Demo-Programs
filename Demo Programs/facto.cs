using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Programs
{
    class FactoProgram
    {
        public void factGet()
        {

            int number =5;
            int factorial =number;


            while(number > 1) 
            {
                number--;
                factorial= factorial*number;
            }
            Console.WriteLine("Factorial Value Of = " + factorial);

            //n!=5x4x3x2x1

            //num=5 5*4*3*2*1
            //num=4 
            //num=3
            //num=2
            //num=1


        }
    }
}
