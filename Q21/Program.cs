using System.Security.Principal;

namespace Q21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.Write("Enter the choice\n");

            string choiceInput = Console.ReadLine();
            int choice;
            if (!int.TryParse(choiceInput, out choice) || (choice != 1 && choice != 2))
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            Console.Write("Enter the account number\n");
            string accountNumber = Console.ReadLine();

            Console.Write("Enter the balance\n");
            string balanceInput = Console.ReadLine();
            decimal balance;
            if (!decimal.TryParse(balanceInput, out balance) || balance < 0)
            {
                Console.WriteLine("Invalid balance.");
                return;
            }

            Account account = new Account
            {
                AccountNumber = accountNumber,
                Balance = balance
            };

            if (choice == 1)
            {
                Console.Write("Enter the amount to be deposit\n");
                string depositInput = Console.ReadLine();
                decimal depositAmount;
                if (!decimal.TryParse(depositInput, out depositAmount))
                {
                    Console.WriteLine("Invalid amount.");
                }
                else
                {
                    decimal newBalance = account.Deposit(depositAmount);
                    Console.WriteLine($"Balance amount {newBalance}");
                }
            }
            else if (choice == 2)
            {
                Console.Write("Enter the amount to be withdraw\n");
                string withdrawInput = Console.ReadLine();
                decimal withdrawAmount;
                if (!decimal.TryParse(withdrawInput, out withdrawAmount))
                {
                    Console.WriteLine("Invalid amount.");
                }
                else
                {
                    decimal newBalance = account.Withdraw(withdrawAmount);
                    Console.WriteLine($"Balance amount {newBalance}");
                }
            }
        }
    }
    
}
