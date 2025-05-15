namespace HelloBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t----------------------\t");
            Console.WriteLine("\tWelcome to Hello Bank!\t");
            Console.WriteLine("\t----------------------\t");


            Console.Write("\tEnter your name: ");
            string Owner = Console.ReadLine();

            BankAccount account = new BankAccount(Owner, 1000);

            Console.WriteLine($"\tHello {account.Owner}, your account number is {account.Number}.");
            Console.ReadLine();
            Console.Clear();

            string choice="";
            decimal amount;

            while (choice != "4")
            {
                Console.WriteLine($"\tYour current balance is {account.Balance}.");
                Console.WriteLine("\tWhat would you like to do?");
                Console.WriteLine("\t1. Deposit");
                Console.WriteLine("\t2. Withdraw");
                Console.WriteLine("\t3. View account history");
                Console.WriteLine("\t4. Exit");
                Console.Write("\tEnter your choice (1-4): ");

                choice = Console.ReadLine();
                if (string.IsNullOrEmpty(choice))
                {
                    Console.WriteLine("\tInvalid choice. Please try again.");
                    continue;
                }
                switch (choice)
                {
                    case "1":
                        Console.Write("\tEnter the amount to deposit: ");
                        amount = Convert.ToDecimal(Console.ReadLine());
                        account.MakeDeposit(amount, DateTime.Now, "Deposit");
                        Console.WriteLine($"Your new balance {account.Balance}");
                        break;

                    case "2":
                        if(account.Balance == 0)
                        {
                            Console.WriteLine("\tInsufficient ammount in account to make transaction.");
                            Console.ReadLine();
                            break;
                        }
                        Console.Write("\tEnter the amount to withdraw: ");
                        amount = Convert.ToDecimal(Console.ReadLine());
                        if (account.Balance <= amount)
                        {
                            Console.WriteLine("\tInsufficient ammount in account to make transaction.");
                            Console.ReadLine();
                            break;
                        }                        
                        account.MakeWithdrawal(amount, DateTime.Now, "Withdrawal");
                        Console.WriteLine($"Your new balance {account.Balance}");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("\tAccount History:");
                        Console.WriteLine(account.GetAccountHistory());
                        account.GetAccountHistory();
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("\tThank you for using Hello Bank. Goodbye!");
                        Console.ReadLine();
                        return;
                    default:
                        Console.WriteLine("\tInvalid choice. Please try again.");
                        Console.ReadLine();
                        break;

                }
                Console.Clear();
            }

        }
    }
}
