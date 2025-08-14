using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Programs
{
    public class arrayExample
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

        public void AssendingOrder()
        {
            
            for (int i = 0; i < uregNum.Length; i++)   //03 20 12 87 35
            {
                for (int j = i+1; j < uregNum.Length; j++)
                {
                    if (uregNum[i] > uregNum[j])
                    {
                        int data = uregNum[j];
                        uregNum[j]=uregNum[i];
                        uregNum[i]=data;
                    }
                }
            }

            Console.WriteLine("Ascending Order:");
            PrintArray();


        }
        public void DessendingOrder() 
        {
            for (int i = 0; i < uregNum.Length; i++)
            {
                for (int j = i+1; j < uregNum.Length; j++)
                {
                    if (uregNum[i] < uregNum[j])
                    {
                        int data = uregNum[j];
                        uregNum[j]=uregNum[i];
                        uregNum[i]=data;
                    }
                }
            }

            Console.Write(" Disassending Order:");
            PrintArray();
            
            
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

