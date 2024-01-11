namespace assignment2
{
    class BankClient
    {
        static void Main()
        {
            IBankRepository bankRepository = new BankRepository();

            while (true)
            {
                Console.WriteLine("\n-----------WELCOME------------");
                Console.WriteLine("1. New Account");
                Console.WriteLine("2. Get Details of an Account");
                Console.WriteLine("3. Get Details of all Accounts");
                Console.WriteLine("4. Deposit Amount");
                Console.WriteLine("5. Withdraw Amount");
                Console.WriteLine("6. Get Transactions of an Account");
                Console.WriteLine("7. Exit");
                Console.WriteLine("------------------------------");

                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // New Account
                        Console.Write("Enter Customer Name: ");
                        string? customerName = Console.ReadLine();

                        Console.Write("Enter Customer Address: ");
                        string? customerAddress = Console.ReadLine();

                        Console.Write("Enter Initial Balance: ");
                        float initialBalance = float.Parse(Console.ReadLine());

                        Console.Write("Enter Account Number: ");
                        int accno = Convert.ToInt32(Console.ReadLine());

                        SBAccount newAccount = new SBAccount
                        {
                            AccountNumber = accno,
                            CustomerName = customerName,
                            CustomerAddress = customerAddress,
                            CurrentBalance = initialBalance
                        };

                        bankRepository.NewAccount(newAccount);
                        Console.WriteLine("Account created successfully");
                        break;

                    case 2:
                        // Get Details of an Account
                        Console.Write("Enter Account Number: ");
                        int accountNumber = Convert.ToInt32(Console.ReadLine());

                        try
                        {
                            SBAccount accountDetails = bankRepository.GetAccountDetails(accountNumber);
                            Console.WriteLine($"Account Details:\n Name:{accountDetails.CustomerName}\n Address: {accountDetails.CustomerAddress}\n Balance: {accountDetails.CurrentBalance}");
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 3:
                        // Get Details of all Accounts
                        List<SBAccount> allAccounts = bankRepository.GetAllAccounts();
                        Console.WriteLine("All Accounts:");
                        foreach (var account in allAccounts)
                        {
                            Console.WriteLine($"Account Number: {account.AccountNumber},\nCustomer Name: {account.CustomerName},\nBalance: {account.CurrentBalance}");
                        }
                        break;

                    case 4:
                        // Deposit Amount
                        Console.Write("Enter Account Number: ");
                        int depositAccountNumber = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Deposit Amount: ");
                        float depositAmount = Convert.ToInt32(Console.ReadLine());

                        try
                        {
                            float newBal = bankRepository.DepositAmount(depositAccountNumber, depositAmount);
                            Console.WriteLine("Amount deposited successfully. Updated Balance = "+newBal);
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 5:
                        // Withdraw Amount
                        Console.Write("Enter Account Number: ");
                        int withdrawAccountNumber = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Withdrawal Amount: ");
                        float withdrawAmount = float.Parse(Console.ReadLine());

                        try
                        {
                            float newBal = bankRepository.WithdrawAmount(withdrawAccountNumber, withdrawAmount);
                            Console.WriteLine("Amount withdrawn successfully. Updated Balance = "+newBal);
                            
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 6:
                        // Get Transactions of an Account
                        Console.Write("Enter Account Number: ");
                        int transactionsAccountNumber = Convert.ToInt32(Console.ReadLine());

                        List<SBTransaction> accountTransactions = bankRepository.GetTransactions(transactionsAccountNumber);
                        Console.WriteLine($"Transactions for Account Number {transactionsAccountNumber}:");
                        foreach (var transaction in accountTransactions)
                        {
                            Console.WriteLine($"Transaction ID: {transaction.TransactionId}, Date: {transaction.TransactionDate}, Amount: {transaction.Amount}, Type: {transaction.TransactionType}");
                        }
                        break;

                    case 7:
                        // Exit
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }
    }
}