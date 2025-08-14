using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Programs
{
    public class TwoDimen
    {
        public int[,] arr = new int[3, 4]
        {   { 1, 2, 3, 4 },
            { 10, 20, 30, 40 },
            { 11, 22, 33, 44 }
        };
        
        public void Align()
        {
            for(int i=0; i<3; i++)
            {
                for(int j =0; j<4; j++)
                {
                    Console.Write(arr[i,j]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
