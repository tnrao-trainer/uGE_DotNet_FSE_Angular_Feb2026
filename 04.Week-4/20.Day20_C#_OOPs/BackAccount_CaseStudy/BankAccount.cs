using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class BankAccount
    {
        private decimal _balance;
        private string _accountNumber;
        private string _accountHolder;

        public decimal  Balance { 
            get
            {
                return _balance;
            }
        }

        public string AccountNumber
        {
            get
            {
                return _accountNumber;
            }
        }

        public string AccountHolder
        {
            get {  return _accountHolder; }
            set {

                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Account Holder Name cannot be empty");
                }

                _accountHolder = value; 
            }
        }


        public BankAccount(string accountNumber, string accountHolder, decimal balance = 0)
        {

            if (string.IsNullOrEmpty(accountNumber))
            {
                throw new ArgumentNullException("Account Number cannot be empty");
            }

            if (string.IsNullOrEmpty(accountHolder))
            {
                throw new ArgumentNullException("Account Holder Name cannot be empty");
            }

            if (balance < 0 )
            {
                throw new ArgumentOutOfRangeException("Balance cannot be nagative");
            }


            _accountNumber = accountNumber;
            _accountHolder = accountHolder;
            _balance = balance;
        }

    

        public void Deposit(decimal amount)
        {
            if(amount < 0)
            {
                throw new ArgumentOutOfRangeException("Amount cannot be nagative");
            }

            _balance += amount;

            Console.WriteLine($"Amount successfully added to balance. Updated Balance : INR.{ _balance.ToString("F2") }");

        }


        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount cannot be zero or lessthan zero");
                return false;
            }

            if(amount > _balance)
            {
                Console.WriteLine("Insufficient Balance");
                return false;
            }

            _balance -= amount;

            Console.WriteLine($"Withdrawn successfully.  Updated Balance. INR.{_balance.ToString("F2")}");

            return true;

        }


    }
}
