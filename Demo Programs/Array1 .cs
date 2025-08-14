using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Programs
{
    public class array1
    {
        public int[] uregNum = new int[5];

        public void GetInput()
        {
            for (int i = 0; i<5; i++)
            {
                Console.WriteLine("Enter a Number");
                uregNum[i] = int.Parse(Console.ReadLine());
            }
        }

        public void SortArray(bool ascending = true)
        {
            for (int i = 0; i < uregNum.Length; i++)
            {
                for (int j = i + 1; j < uregNum.Length; j++)
                {
                    bool shouldSwap = ascending ? uregNum[i] > uregNum[j] : uregNum[i] < uregNum[j];
                    {
                        if (shouldSwap)
                        {
                            int data = uregNum[j];
                            uregNum[j] = uregNum[i];
                            uregNum[i] = data;
                        }
                    }
                }
                Console.WriteLine(ascending ? "Ascending Order:" : "Descending Order:");
                PrintArray();
            }
        }
        
        public void PrintArray()

        {

            for (int i = 0; i<uregNum.Length; i++)
            {
                Console.Write(uregNum[i]+ " ");
            }

        }
    }
}

