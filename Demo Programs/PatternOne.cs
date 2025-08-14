using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Programs
{
    public class PatternOne
    {
        public int row = 0;
        
       public void ReadTheNumber()
        {
            for (int row = 1; row<=10; row++)
            { 
                for (int col=1; col<=row; col++)
                {
                    Console.Write(col+" ");

                }
                Console.WriteLine();

            }
            
        }

    }
}
