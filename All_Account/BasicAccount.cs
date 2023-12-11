using Assignment1_Kasem_Razok.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Kasem_Razok.All_Account
{
    internal class BasicAccount : Account_A, IDeposit, IWithdraw
    {
        // default construter 
        public BasicAccount() { }
        // it's constructer
        public BasicAccount(double Balance) : base(Balance) { }

    }
}
