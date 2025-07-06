using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Programs
{
    public class bankStatement
    {
        public static void Main(String[] args)
        {
            bankStatement bankdetails = new bankStatement();
            bankdetails.value();
            bankdetails.balance();
            bankdetails.value();
            bankdetails.balance();
            bankdetails.value();
            bankdetails.balance();
        }
        public int sathish ; public int karthi;

        public void value()
        {
            Console.WriteLine("Enter a Value ");
            sathish=karthi=int.Parse(Console.ReadLine());
        }
        public void balance()
        {
            if (sathish > 500)
                Console.WriteLine("Congress Karthi All the Best !!!");
            else if (karthi < 500)
                Console.WriteLine("Congress Sathishwaran All the Best !!!");
            else if (karthi == sathish)
                Console.WriteLine("Both are Same !!!");
            else
                Console.WriteLine("Summa Illa Bro");
        } 
    }
}
