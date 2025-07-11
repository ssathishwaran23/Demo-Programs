using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Programs
{
    public class Multiple
    {
        public void multipleGet() 
        {
            int a;
            

            Console.WriteLine("Enter the Value");
            a = int.Parse(Console.ReadLine());

            for (int i =a; i<=1000*20; i+=3)
            {
                Console.WriteLine(i);
            }
            


        }
    }
}
