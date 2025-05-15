namespace HelloBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t----------------------\t");
            Console.WriteLine("\tWelcome to Hello Bank!\t");
            Console.WriteLine("\t----------------------\t");


            Console.Write("\tEnter your name:\t");
            string Owner = Console.ReadLine();

            BankAccount account = new BankAccount(Owner, 1000);

            Console.WriteLine($"\tHello {account.Owner}, your account number is {account.Number}.");
            Console.WriteLine($"\tYour current balance is {account.Balance}.");
            Console.WriteLine("\t----------------------\t");

            Console.WriteLine("\tWhat would you like to do?");
            Console.WriteLine("\t1. Deposit");
            Console.WriteLine("\t2. Withdraw");
            Console.WriteLine("\t3. View account history");
            Console.WriteLine("\t4. Exit");
            Console.Write("\tEnter your choice (1-4):\t");

            string choice="";
            decimal amount;

            while (choice != "4")
            {
                
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("\tEnter the amount to deposit:\t");
                        amount = Convert.ToDecimal(Console.ReadLine());
                        account.MakeDeposit(amount, DateTime.Now, "Deposit");
                        Console.WriteLine($"Your new balance {account.Balance}");
                        break;

                    case "2":
                        Console.Write("\tEnter the amount to withdraw:\t");
                        amount = Convert.ToDecimal(Console.ReadLine());
                        account.MakeWithdrawal(amount, DateTime.Now, "Withdrawal");
                        Console.WriteLine($"Your new balance {account.Balance}");
                        break;
                    case "3":
                        Console.WriteLine("\tAccount History:");
                        Console.WriteLine(account.GetAccountHistory());
                        account.GetAccountHistory();
                        break;
                    case "4":
                        Console.WriteLine("\tThank you for using Hello Bank. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("\tInvalid choice. Please try again.");
                        break;

                }
            }

        }
    }
}
