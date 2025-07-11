using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Programs
{
    public class Student

    {
        public int Tamil;
        public int English;
        public int Maths;
        public int Scince;
        public int Social;
        public int Total = 500;
        
        public void maksGet()
        {
            
Tamil:

            Console.WriteLine("**************************************");
            Console.WriteLine("Welcome to Higher Secondary Education");
            Console.WriteLine("**************************************");
            Console.WriteLine("Enter a Tamil Subject Mark ");
            Tamil = int.Parse(Console.ReadLine());
            if (Tamil >= 0 && Tamil<=100)
            {
                if (Tamil >= 35)
                {
                    Console.WriteLine("Tamil Subject Pass");
                }
                else
                {
                    Console.WriteLine("Tamil Subject Fail");
                }
            }
            else
            {
                Console.WriteLine("Invalid Mark Please Enter Valid Mark");
                goto Tamil;
            }
English:
            Console.WriteLine("Enter a English Subject Mark ");
            English = int.Parse(Console.ReadLine());
            if (English >= 0 && English<=100)
            {
                if (English >= 35)
                {
                    Console.WriteLine("English Subject Pass");
                }
                else
                {
                    Console.WriteLine("English Subject Fail");
                }
            }
            else
            {
                Console.WriteLine("Invalid Mark Please Enter Valid Mark");
                goto English;
            }
Maths:
            Console.WriteLine("Enter a Maths Subject Mark ");
            Maths = int.Parse(Console.ReadLine());
            if (Maths >= 0 && Maths<=100)
            {
                if (Maths >= 35)
                {
                    Console.WriteLine("Maths Subject Pass");
                }
                else
                {
                    Console.WriteLine("Maths Subject Fail");
                }
            }
            else
            {
                Console.WriteLine("Invalid Mark Please Enter Valid Mark");
                goto Maths;
            }
Scince:
            Console.WriteLine("Enter a Scince Subject Mark ");
            Scince = int.Parse(Console.ReadLine());
            if (Scince >= 0 && Scince<=100)
            {
                if (Scince >= 35)
                {
                    Console.WriteLine("Scince Subject Pass");
                }
                else
                {
                    Console.WriteLine("Scince Subject Fail");
                }
            }
            else
            {
                Console.WriteLine("Invalid Mark Please Enter Valid Mark");
                goto Scince;
            }
Social:
            Console.WriteLine("Enter a Social Subject Mark ");
            Social = int.Parse(Console.ReadLine());
            if (Social >= 0 && Social<=100)
            {
                if (Social >= 35)
                {
                    Console.WriteLine("Social Subject Pass");
                }
                else
                {
                    Console.WriteLine("Social Subject Fail");
                }
            }
            else
            {
                Console.WriteLine("Invalid Mark Please Enter Valid Mark");
                goto Social;
            }
        }
        public void maksSet ()
        {
            Console.WriteLine("Total of Your Mark is :" + (Tamil+English+Maths+Scince+Social));
            if (Tamil >=35 && English>=35 && Maths >=35 && Scince>=35 && Social>=35)
            {
                Console.WriteLine("Your are Eligible For Higher Education ");
                Console.WriteLine("**************************************");
                Console.WriteLine("Congrass All The Best !!!");
                Console.WriteLine("**************************************");

               
            }

            else { Console.WriteLine("Your are Not Eligible");
                Console.WriteLine("**************************************");
                Console.WriteLine("Sorry ,You Will Clear Arrears !");
                Console.WriteLine("**************************************");
                
            }

        }
    }
}
