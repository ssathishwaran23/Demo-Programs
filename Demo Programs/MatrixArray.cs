using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Programs
{
    public class RepeatedArray
    {
        public int[] bookNumber = { 10, 20, 30, 40, 50, 10, 20, 30, 40, 50, 10, 20, 30 };

        public void Process()
        {
            Console.WriteLine("Enter a Book Number:");
            int input = int.Parse(Console.ReadLine());

            int repeatInNumber = RepeatCountArray(input);
            Console.WriteLine($"The number {input} appears {repeatInNumber} times.");

            Console.WriteLine("\nFrequency of all book numbers:");
            WriteArray();
        }

        public int RepeatCountArray(int value)
        {
            int count = 0;
            for (int i = 0; i < bookNumber.Length; i++)
            {
                if (value == bookNumber[i])
                {
                    count++;
                }
            }
            return count;
        }

        public void WriteArray()
        {
            int[] freq = new int[bookNumber.Length];

            for (int i = 0; i < bookNumber.Length; i++)
            {
                freq[i] = 1;
                for (int j = i + 1; j < bookNumber.Length; j++)
                {
                    if (bookNumber[i] == bookNumber[j])
                    {
                        freq[i]++;
                        freq[j] = -1;
                    }
                }
            }

            for (int i = 0; i < bookNumber.Length; i++)
            {
                if (freq[i] != -1)
                {
                    Console.WriteLine($"Book Number {bookNumber[i]} => {freq[i]} times");
                }
            }
        }               
    }

}