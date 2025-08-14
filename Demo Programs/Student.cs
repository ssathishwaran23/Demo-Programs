using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
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
            Console.WriteLine("**************************************");
            Console.WriteLine("Welcome to Higher Secondary Education");
            Console.WriteLine("**************************************");
            Tamil = getmark("Tamil");
            validateMark("Tamil", Tamil);
            English = getmark("Engilsh");
            validateMark("English", English);
            Maths = getmark("Maths");
            validateMark("Maths", Maths);
            Scince = getmark("Scince");
            validateMark("Scince", Scince);
            Social = getmark("Social");
            validateMark("Social", Social);
        }

        public void maksSet ()
        {
            Console.WriteLine("");
            Console.WriteLine("Total of Your Mark is :" + (Tamil+English+Maths+Scince+Social));
            Console.WriteLine("");
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
        public int getmark(String subjectName) 
        {
markvalid:
            Console.WriteLine("Enter a {0} Subject Mark ", subjectName);
            int mark = int.Parse(Console.ReadLine());
            if(! (mark >= 0 && mark<=100))                
            {
                Console.WriteLine("Invalid Mark Please Enter Valid Mark");
                goto markvalid;                
            }
            return mark;
        }
        public void validateMark(String subjectName,int mark)
        {
            if (mark >= 0 && mark<=100)
            {
                if (mark >= 35)
                {
                    Console.WriteLine("{0} Subject Pass",subjectName);
                }
                else
                {
                    Console.WriteLine("{0} Subject Fail", subjectName);
                }
            }
            else
            {
                Console.WriteLine("Invalid Mark ");
            }
        }
    }
}
