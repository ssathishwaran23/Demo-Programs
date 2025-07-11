using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Programs
{
    public class Ifmark
    {
        public float a;

        public void ifgrade()
        {
label:
            Console.WriteLine("Enter Your Mark");
            a =float.Parse(Console.ReadLine());

            {
                if (a<=100 && a >=0)
           
                {


                    if (a <= 100 && a > 90)
                    {
                        Console.WriteLine("Your Grade Is A+");
                    }
                    else if (a <= 90 && a > 80)
                    {
                        Console.WriteLine("Your Grade Is A");

                    }
                    else if (a <= 80 && a > 70)
                    {
                        Console.WriteLine("Your Grade Is B");

                    }
                    else if (a <= 70 && a > 60)
                    {
                        Console.WriteLine("Your Grade Is C");

                    }
                    else if (a <= 60 && a > 50)
                    {
                        Console.WriteLine("Your Grade Is D");

                    }
                    else if (a <= 50 && a > 40)
                    {
                        Console.WriteLine("Your Grade Is E");

                    }
                    else if (a <= 40 && a > 0)
                    {
                        Console.WriteLine("Your Fail");

                    }
                    else
                    {
                        Console.WriteLine("Your Mark Is Low Please Improve ");
                    }
                }

                else
                {
                    Console.WriteLine("Please Enter Correct Input");
                }
                goto label;


            }
        }
    }
}
