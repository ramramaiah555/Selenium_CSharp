using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp.Oops.Encapsulation
{
    internal class Execution
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Deposit(500);
            account.Withdraw(200);
        } 
    }
}
