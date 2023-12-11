using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Kasem_Razok.All_Customer
{
    internal class IndividualCustomer : Customer_A
    {
        // constructer & base:
        public IndividualCustomer(string FirstName, string LastName, DateTime BirthDate, string Email, string PhoneNumber , string HomeAddress ,string WorkingAddress) : base(FirstName, LastName, BirthDate, Email, PhoneNumber)
        {
            this .HomeAddress = HomeAddress;
            this .WorkingAddress = WorkingAddress;
        }

        public string HomeAddress { get; set; }
        public string WorkingAddress { get; set; }  
        
    }
}

