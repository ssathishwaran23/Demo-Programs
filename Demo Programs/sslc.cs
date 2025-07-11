using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSLC_Data
{
    public class Ifall
    {

       public int s1 = 480; public int s2 = 420; public int s3 = 270;


        public void ifday()
        {
            if (s1<=500 && s2 <=500 && s3 <=500 )
            {
                Console.WriteLine("Then Student is Great");

            }
            else if (s1<=400 && s2 <=400 && s3 <=400)
            {
                Console.WriteLine("Then Student is Ok level");

            }
            else if (s1<=300 && s2 <=300 && s3 <=300)
            {
                Console.WriteLine("Then Student is Improve Pannanum ");

            }
            else if (s1<=200 && s2 <=200 && s3 <=200)
            {
                Console.WriteLine("Then Student is Fail But Improve Student ");

            }

        }
    }
}
