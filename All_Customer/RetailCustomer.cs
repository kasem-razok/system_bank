using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Kasem_Razok.All_Customer
{
    internal class RetailCustomer : Customer_A
    {
        // constructer & base:
        public RetailCustomer(string FirstName, string LastName, DateTime BirthDate, string Email, string PhoneNumber, string CompanyAddress) : base(FirstName, LastName, BirthDate, Email, PhoneNumber)
        {
            this .CompanyAddress = CompanyAddress;  
        } 
        public string CompanyAddress { get; set; }  

    }
}
