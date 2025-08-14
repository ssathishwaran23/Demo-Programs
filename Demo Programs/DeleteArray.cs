using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Programs
{
    
    public class DeleteArray
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        
        int indexToDelete = 2;        
        public void DeleteArrayNum()
        {
            int[] newNumbers = new int[numbers.Length -1];
            for (int i = 0; i<indexToDelete; i++)
            {
                newNumbers[i] = numbers[i];
            }

            for (int i = indexToDelete + 1; i<numbers.Length; i++)
            {
                newNumbers[i - 1] = numbers[i];
            }
            Console.WriteLine("Array after deletion:");
            Console.WriteLine("[" + string.Join(", ", newNumbers) + "]");
        }
    }
}
