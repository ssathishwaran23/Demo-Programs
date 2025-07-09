using System;
using System.Collections.Generic;
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
                Console.WriteLine(no1);
            }
            else if (no2>no3 && no2>no1)
            {
                Console.WriteLine(no2);
            }
            else if (no3>no1 && no3>no2)
            {
                Console.WriteLine(no3);
            }
            else
            {

                Console.WriteLine("All Are Equal");
            }
        }
    }
}
