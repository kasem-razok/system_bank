using Assignment1_Kasem_Razok.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Kasem_Razok.All_Account
{
    internal class Account_A
    {

        // default construter 
        public Account_A() { }


        // it's constructer
        public Account_A( double Balance ) 
        {
            this .Balance = Balance;
            Isclosed = false;
            CreatedDate = DateTime.Now;

        }
       
        public double Balance { get; protected set; }
        public bool Isclosed { get; set; }
        public DateTime CreatedDate { get; set; }


        public void Delete()
        {
            if (Isclosed)
            {
                Console.WriteLine("the account it is colsed ");
                return;
            }
            if (Balance == 0)
            {
                Isclosed = true;
            }
            else
            {
                Console.WriteLine("the balance is not 0 so can,t the account ");
            }
        }


        //deposit  to balance
        public void deposit(double amount)
        {
            if (Isclosed)
            {
                Console.WriteLine("the account it is colsed.....");
                return;
            }
            else
            {
                Balance += amount;
            }
        }

        //Withdrawal from balance
        public void withdraw(double amount)
        {
            if (Isclosed)
            {
                Console.WriteLine("the account it is colsed.....");
                return;
            }
            if (Balance < amount)
            {
                try { }
                catch (Exception e)
                {
                    Console.WriteLine("insufficient balance");
                }
           
            }
            if (Balance >= amount)
            {
                Balance -= amount;
            }
        }




    }
}
