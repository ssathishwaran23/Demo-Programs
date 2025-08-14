using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Programs
{
    public class ArrayScecond

    {
        public int[] studentNum = new int[6];
        public void data()
        {
            int[] studentNum = { 20, 23, 32, 52, 62, 65 };

            int n = studentNum.Length;


            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (studentNum[i]<studentNum[j])
                    {
                    int data = studentNum[j];
                    studentNum[j]=studentNum[i];
                    studentNum[i]=data;
                    }
                }
            }

            for (int i = 0; i<n; i++)
            {
                Console.WriteLine("Ascending Order:");
                Console.Write(studentNum[i]+ " ");
            }
        }


    }
}

