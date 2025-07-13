using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Programs
{
    public class Arraynewclass
    {
         public int[] num = new int[10];

        public void arrayGet()
        { 
            for (int i = 0; i<10; i++)
            {
                Console.WriteLine("Enter the Value Element for[{0}]",i);
                num[i]=int.Parse(Console.ReadLine());
            }
        }
        public void arraySet()
        {
            for (int i = 0 ; i<10; i++)
            {

                Console.WriteLine("The Value[{0}]", num[i]);
            }
            
        }
    }
}
