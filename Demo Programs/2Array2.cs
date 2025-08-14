using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Programs
{
    public class ArrayOperations
    {
        public int[,] array = new int[3, 3];


        public void ReadArray()
        {
            Console.WriteLine("Enter 9 numbers for a 3x3 array:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter value for position [{i}],[{j}]: ");
                    array[i, j]=int.Parse(Console.ReadLine());
                }
            }
            PrintArray();
        }
        public void FindHighest()
        {
            int highest = array[0, 0];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (array[i, j] > highest)
                    {
                        highest = array[i, j];
                    }
                }
            }

            Console.WriteLine("The highest number is:"+highest);
        }
        public void FindRepeatedCount()
        {
            Console.WriteLine("Enter a value to find in array");
            int repeatedValue = int.Parse(Console.ReadLine());
            int valueCount = 0;

            for (int i = 0; i<3; i++)
            {
                for (int j = 0; j<3; j++)
                {

                    if (array[i, j]==repeatedValue)

                    {
                        valueCount++;
                    }
                }
            } 
            Console.WriteLine("The Repeated Value is :"+ valueCount);
        }
        public void PrintArray()
        {
            Console.WriteLine("Array contents:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
            
}
    
