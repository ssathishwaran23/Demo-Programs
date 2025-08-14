using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Programs
{
    public class Userdata
    {
        public int UregNum;

        public int userRead()
        {
            for (int i = 0; i<5; i++)
            Console.WriteLine("Enter a Register Number");
            UregNum = int.Parse(Console.ReadLine());
            return UregNum;
        }
        public void userWrite(int UregNum)
        {
            for (int i = UregNum; i<5;i++)
            Console.WriteLine("Register Number [{0}] :", UregNum);           
        }


    }
}



