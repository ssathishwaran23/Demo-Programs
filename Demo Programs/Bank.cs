using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankData
{
    public  class Bank
    {
        public float withdrawAmount; public float depositAmount;
        public float Balance;
        
        public void  AccountData()
            
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("Enter A Deposit Amount");
            depositAmount = float.Parse(Console.ReadLine());
            Console.Clear();
            Balance = depositAmount + Balance;
            Console.WriteLine("Your Account Balance :" + Balance);
            Console.WriteLine("=========================================");

        }
        public void Withdraw()
        {
        with:
            Console.WriteLine("Enter Your Withdraw Amount");
            withdrawAmount = float.Parse(Console.ReadLine());

            if (withdrawAmount > Balance)    
            {
                Console.WriteLine("=========================================");
                Console.WriteLine("Your Balance Is Low !!!");
                Console.WriteLine("=========================================");
                goto with;
            }
            else
            {
                Console.WriteLine("Your balance is  "+ (Balance-withdrawAmount) );
                Console.WriteLine("=========================================");
                Console.WriteLine("Thank you For Visit Your Bank !!!");
                Console.WriteLine("=========================================");

            }


        }


    }
}
