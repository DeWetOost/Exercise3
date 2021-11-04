using System;
using System.Collections.Generic;

namespace TheBanker
{
    // class representing a bank account with these properties
    public class BankAccount
    {
        public string Name { get; }
        public double Balance { get; }
        public string Number { get; set; }

        public BankAccount(string accountName, double initialBalance, string accountNumber)
        {
            this.Name = accountName;
            this.Balance = initialBalance;
            this.Number = accountNumber;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //main loop
            List<BankAccount> bank = new List<BankAccount>();
            bool incorrect = true;
            while (incorrect)
            {
                Console.WriteLine("1. Open account");
                Console.WriteLine("2. List accounts");
                Console.WriteLine("3. Show (individual) account details");
                Console.WriteLine("4. Enter deposit");
                Console.WriteLine("5. Enter withdrawal");
                Console.WriteLine("6. Enter transfer");
                Console.WriteLine("X. Exit");

                // give user the option to choose which menu item to action
                Console.WriteLine("Please select which option you would like to view and press 'Enter': ");
                string userSelect = Console.ReadLine();

                // open a new account
                if (userSelect == "1")
                {
                    // ask user for account name and initial balance
                    Console.WriteLine("Enter account name: ");
                    string accountName = Console.ReadLine();
                    Console.WriteLine("Enter initial balance: ");
                    double initialBalance = double.Parse(Console.ReadLine());

                    // assign random account number
                    string startWith = "11";
                    Random generator = new Random();
                    string r = generator.Next(0, 999999).ToString("D6");
                    string accountNumber = startWith + r;
                    Console.WriteLine("Account number: ");
                    Console.WriteLine(accountNumber);

                    bank.Add(new BankAccount(accountName, initialBalance, accountNumber));
                    Console.WriteLine("Bank account added!");
                    Console.ReadLine();
                }

                // list accounts command to enable to view each account (Number, Name, Balance)
                else if (userSelect == "2")
                {
                    Console.WriteLine("List of accounts:");
                    Console.WriteLine(bank);
                }
                    
                // give user the option to view specific account details
                // else if (userSelect == "3")
                // {
                //     string nameCheck = Console.ReadLine();
                //     if (nameCheck = accountName)
                //     {
                //         Console.WriteLine("Account Number: " + accountNumber);
                //         Console.WriteLine("Balance: " + initialBalance);
                //     }
                // }
                
                // close list if user select exit
                else if (userSelect == "X")
                {
                    incorrect = false;
                }
                else
                {
                    Console.WriteLine("Invalid Syntax!");
                    Console.ReadLine();
                }
            }
        }
    }
}
