using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Programs
{
    public class AddEven
    {
        public int num;
        public void addGet()
        {

            Console.WriteLine("Enter A Value");
            num =int.Parse(Console.ReadLine());

            for (int i = 1; i<num; i++) //i=i-1  //i=i=1  //i=i+1 i=i+2  
            {
                //Console.WriteLine(i);  //1,0,-1,-2,-3  // 1,1,2,4,,6,8

                if (!(i % 2 == 1))          //i=1, 1,2,2
                    
                {
                    Console.WriteLine(i);
                }
            }
            //1-10 /2= 0
        }

        //100>1


    }
}
