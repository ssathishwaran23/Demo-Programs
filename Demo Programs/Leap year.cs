using System;


namespace Demo_Programs
{
    public class LeapYear
    {
        public void yearGet()
        {
            int year;
            
label:
            Console.WriteLine("Enter Year");
            year = int.Parse(Console.ReadLine());

            if (year % 4 == 0)
            {
                Console.WriteLine("This Year is Leap Year :" + year);
            }
            else
            {
                Console.WriteLine("This not in leap year");
                Console.WriteLine("Right input year");


            }
            goto label;



        }
    }
}
