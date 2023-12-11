using Assignment1_Kasem_Razok.All_Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment1_Kasem_Razok.All_Customer
{
    internal class Customer_A
    {
        // it's constructer 
        public Customer_A (string FirstName, string LastName, DateTime BirthDate, string Email, string PhoneNumber )
            {
            this .FirstName = FirstName;
            this .LastName = LastName;
            this .BirthDate = BirthDate;
            this .Email = Email;
            this .PhoneNumber = PhoneNumber;
            IsdDeleted = false;
           CreatedDate = DateTime.Now;
            Accounts = new List<Account_A> ();

                }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; private set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

         public DateTime CreatedDate { get; set; }
        public bool IsdDeleted {  get; private set; }

        private List<Account_A> Accounts { get; set; }

        // add account for customer 
        public void AddAccount (Account_A accounts)
        {
            // if customer -> retial created  salary account 
            if (this is RetailCustomer && accounts is SalaryAccount)
            {
                Console.WriteLine("This account is forbidden to the customer RetailCustomer ");
                return;
            }

            // If the customer's account is already deleted
            if (IsdDeleted)
            {
                Console.WriteLine("the account deleted");
            }
            else
            {
                Accounts.Add(accounts);
            }
        }
        // recovery account after the customer deleted 
        public List<Account_A>  InfoAccount()
        {
          if (IsdDeleted)
            {
                Console.WriteLine("the account is deleted");
                return null;
            }
            return Accounts;
        }

        // return all balance
      private double allbalance()
        {
            double balance_A = 0;
            foreach (Account_A  A_account in Accounts)
            { balance_A = balance_A + A_account.Balance; }

            return balance_A;
        }


        public void Delete ()
        {
            // the account already deleted
            if (IsdDeleted) { Console.WriteLine("This account is already deleted");
                return;
            }
            // If there is a balance in the account
            else if ( allbalance() > 0)
            { Console.WriteLine("the account can't deleted becaus you have balance$$ (: ");
                return;
            }
            IsdDeleted = true;
        }

        // print the customer -> account
        public override string ToString()
        {
            if (IsdDeleted)
                return "no account";
            else
                return $"{FirstName}  {LastName} _ Balance :{allbalance()}$";
        }
    }
}
