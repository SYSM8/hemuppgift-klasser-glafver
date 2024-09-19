using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string accountNumber, string accountHolder, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited:{amount}, New Balance: {Balance}");
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew: {amount}, New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("There is not enough money on the account");
            }

        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Balance: {Balance}");
        }
    }
}
