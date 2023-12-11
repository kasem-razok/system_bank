using Assignment1_Kasem_Razok.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Kasem_Razok.All_Account
{
    internal class SavingsAccount : Account_A, IDeposit
    {

        // default construter 
        public SavingsAccount() { } 

        // it's constructer
        public SavingsAccount(double Balance) : base(Balance) { }

    }
}
