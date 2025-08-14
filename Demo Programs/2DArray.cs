using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Programs
{
    public class _2DArray
    {
        public int[,] data = new int[2,3];
      

        public void Read()
        {
            for (int i = 0; i<2; i++)
            {
                for (int j=0; j<3; j++)
                {
                    Console.WriteLine("Enter a Value");
                    data[i,j]=int.Parse(Console.ReadLine());
                }
            }
        }
            public void Write()
        {
            for (int i= 0; i< 2; i++) //
            {
                for (int j=0; j<3; j++)
                {
                    Console.WriteLine("The value are in 2D :[{0}],[{1}]",data[i, j]);
                }
            }

        }
        public void FindLargeValue()
        {
            int currentLargeValue = data[0, 0];

            for(int i= 0; i<2; i++)
            {
                for(int j=0; j<3; j++)
                {
                    if (data[i, j]> currentLargeValue)
                    {
                        currentLargeValue =data[i, j];
                    }
                }
            }
            Console.WriteLine("The Large Value is ", currentLargeValue);
        }
        public void FindTheReapetedCount()
        {
           

        }

        }
       

    }
    


