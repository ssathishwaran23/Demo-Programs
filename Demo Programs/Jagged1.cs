using System;

namespace Demo_Programs
{
    public class Jagged1
    {
        public int[][] arr = new int[3][];
        public int value = 1;

        public void Read()
        {
            
            for (int i = 0; i < 3; i++)
            {
                arr[i] = new int[3]; 
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i][j] = value;
                    value += 1;
                }
            }

            int total = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        total += arr[i][j];
                    }
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Diagonal Total: " + total);
        }
    }
}
