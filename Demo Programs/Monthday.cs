using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Programs
{
    public class MonthDay
    {
        public int month =12;
        public int days=30|31;

        public int num;
    
    public void monthGet()
        {
            Console.WriteLine("Enter a Month &Day");
            num = int.Parse(Console.ReadLine());


            if (num>month  )
            {
                Console.WriteLine("");
            }
            else 
            {
                Console.WriteLine("Enter Error");
            }
        }
    } }
