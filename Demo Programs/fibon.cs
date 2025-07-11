using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Programs
{
    public class fibon
    {
        public int first; public int sec; public int swap;

        public void newclass()
        {
            first = 0;
            sec = 1;
                        

            Console.WriteLine(first); 
            Console.WriteLine(sec);

            int i = 1;
            while (i<=4)
            {

                swap =first+sec;
                Console.WriteLine(swap);
                first=sec;
                sec=swap;
            }
        }

    }
}
//Expect Out Put 30
// 0 1 1 2 3 5 8 13 21...
// T = F+S
//10!
