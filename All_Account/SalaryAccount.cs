using Assignment1_Kasem_Razok.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Kasem_Razok.All_Account
{
    internal class SalaryAccount : Account_A, IWithdraw
    {
        // default construter 
        public SalaryAccount() { }  

        // it's constructer
        public SalaryAccount(double Balance) : base(Balance) { }

    }
}
