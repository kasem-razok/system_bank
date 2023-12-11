using Assignment1_Kasem_Razok.All_Account;
using Assignment1_Kasem_Razok.All_Customer;

namespace Assignment1_Kasem_Razok
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Define a retail Customer 
           RetailCustomer retailCustomer = new RetailCustomer("kasem" , "razok" ,DateTime.Parse("2002/1/8") , "kasemrazok6@gmail.com" , "+46720040104" ,"Green idlib");
           
            // creat 3 different accounts with 3 diffrent types
            var basicAccount = new BasicAccount();
            var loanAccount = new LoanAccount();    
          

            // assign the created accounts to the "Retail Customer "
            retailCustomer.AddAccount(basicAccount);
            retailCustomer.AddAccount(loanAccount);
          

            //Doposit the (depositable) accounts with 100
            basicAccount.deposit(100);
            loanAccount.deposit(100);

            // withdraw 60 from two accounts 
            basicAccount.withdraw(60);
            loanAccount.withdraw(60);


            // call yourCustomer.Tostring() to print the fullname and the total balance
            Console.WriteLine(retailCustomer.ToString() + "                                 " + " :( ");

            // ************************************************************************************

            // Define an individual cUSTOMER 
            IndividualCustomer individualCustomer= new IndividualCustomer("teacher mohammad","msallati", DateTime.Parse("1988/10/10"), "mohammadmallati@gmail.com" , "+905366202052" , "halab" , "tyrkia");
           
            //Create 4 different account with 4 different types 
            var basicAccount1 = new BasicAccount(0); 
            var loanAccount1 = new LoanAccount(0);   
            var salaryAccount1 = new SalaryAccount(0);
            var savingsAccount1 = new SavingsAccount(0);

            // assign 4 differtent accounts with 4 different types 
            individualCustomer.AddAccount(basicAccount1);
            individualCustomer.AddAccount(loanAccount1);
            individualCustomer.AddAccount(salaryAccount1);
            individualCustomer.AddAccount(savingsAccount1);

            // Deposit the (depositable) account with 200
            basicAccount1.deposit(200);
            loanAccount1.deposit(200);
            savingsAccount1.deposit(200);

            //withdraw 80 from two accounts
            basicAccount1.withdraw(80);
            loanAccount1.withdraw(80);
            salaryAccount1.withdraw(80);

            // Call yourCustomer Tosting() to print the fullname and the total balance 
        Console.WriteLine(individualCustomer.ToString() + "       " +"You're rich :)");

            Console.WriteLine("---------------------------");
            Console.WriteLine("thanks for teacher Mohammad.M");    

        }
    }
}
