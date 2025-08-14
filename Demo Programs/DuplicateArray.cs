using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Programs
{
    public class DuplicateArray
    {
        
        int[] arr = { 10, 20, 30, 40, 10, 20, 30, 50, 10 };
        int[] freq = new int[10];
        string[] output = new string[10];
       
       // public void ReadDuplicateArray()
       // {
       //     int outputIntex = 0;
       //     int n = 0;

       //     Console.WriteLine("Enter a Value");
       //     n=int.Parse(Console.ReadLine());

       //     for (int i = 0; i<arr.Length; i++)
       //     {
       //         int freqenceExitCount = 0;
       //         for (int h = 0; h<freq.Length; h++)
       //         {

       //             if (arr[i]==freq[h])
       //             {
       //                 freqenceExitCount++;
       //             }
       //         }
       //         if (freqenceExitCount==0)
       //         {
       //             int incrmentValue = 0;
       //             for (int j = i+1; j<arr.Length; j++)
       //             {
       //                 if (arr[i]==arr[j])
       //                 {
       //                     incrmentValue++;
       //                 }
       //             }
                    
       //             output[outputIntex]=arr[i]+"-"+incrmentValue;   //10-3  20-5  30-2  40-1  50-1
       //             outputIntex++;
       //         }
       //         if (arr[i]==n)
       //         {
       //             Console.WriteLine($"Value {n} found at index {i}");
       //         }

       //     }            
       //     for(int i = 0; i<output.Length; i++)
       //     {
       //         Console.WriteLine(output[i]);

                
       //     }            

       // }
       // public void WriteArray() 
       // {
       //     int countofDup = 0;
       //     int unique=0;
            
       //     for (int i = 0; i<freq.Length; i++)
       //     {
       //         if (freq[i]>1)
       //         {                 
       //             countofDup++;
       //         }
       //         if (freq[i]==1)
       //         {
       //             unique=freq[i];
       //         }
               
       //     }
       //     Console.WriteLine("Then Duplicate Value is   :"+ countofDup);
       //     Console.WriteLine("Then Unique Value is  :"+ unique);
            


       // }
        public void Process()
        {
with:
            Console.WriteLine("Enter a Array value");
            int userinput = int.Parse(Console.ReadLine());
            int noOfTimes=FindNoOfTimes(userinput);
            string findofIndex = FindIndex(userinput);
            Console.WriteLine(userinput+" No of Times "+noOfTimes+" Index Positions "+findofIndex);
            goto with;
        }

        public int FindNoOfTimes(int input)
        {
            int incrmentValue = 0;
            
            for (int i = 0; i<arr.Length; i++)
            {
                       if (arr[i]==input)
                        {
                            incrmentValue++;
                        }             

            }
            return incrmentValue;        

        }
        public string FindIndex(int input)
        {
            string result = "";
            
            for (int i = 0; i<arr.Length; i++)
            {               
                if (arr[i]==input)
                {
                    result+=(i+",");
                   
                }
            }
            return result;

        }
        
        ///value 10 found at indexs 1,2,3,4,
    }     

        
    }
