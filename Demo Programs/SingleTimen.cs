using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Programs
{
    public class SingleTimen
    {
        public int[] arr = new int[] { 7, 3, 5, 1, 9, 2 };

       public void SearchNumber()
        {
s:
            Console.WriteLine("Enter the number to Search :");
            int num=int.Parse(Console.ReadLine());
            bool found = false;            

            for (int i = 0; i<arr.Length; i++)
            {
                if (num==arr[i])
                {
                    found=true;
                    break;
                }
            
            }
            if (found)
            {
                Console.WriteLine("Element found");
            }
            else
            {
                Console.WriteLine("Element not found");
            }
            goto s;
        }
    }
}
