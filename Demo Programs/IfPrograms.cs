using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Programs
{
    public class program1
    {
        public int no1 = 5; public int no2 = 10; public int no3 = 10;

        public void ifget()
        {
            if (no1>no2 && no1>no3)
            {
                Console.WriteLine(no1 +"No 1 Is Big");
            }
            else if (no2>no3 && no2>no1)
            {
                Console.WriteLine(no2 +" No 2 Is Big");
            }
            else if (no3>no1 && no3>no2)
            {
                Console.WriteLine(no3 +" No 3 Is Big");
            }
            else
            {
               
                    Console.WriteLine("All Or Not Equal");
            }

        
        }
    }
}
