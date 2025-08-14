using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Programs
{
    public class JaggedArray
    {
        public int[][] arr = new int[3][];
        public void Align()
        {
            arr[0]=new int[4] { 1, 2, 3,4};
            arr[1]=new int[3] {10,20,30};
            arr[2]=new int[4] { 11, 22, 33, 44 };

            foreach (int[] ar in arr)
            {
                foreach(int i in ar)
                {
                    Console.Write(i+"\t");
                }
                Console.WriteLine();            
            }  
        }
    }
}
