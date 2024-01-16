using BankRep.Models;

namespace BankRep
{
    public class BankClient
    {
        public static void Main()
        {
            IBankRepository AryanBank = new BankRepository();
            // newacc(AryanBank);
            // getDetails(AryanBank);
            // displayaccs(AryanBank);
            // getAllAccounts(AryanBank);
            // depositAmount(AryanBank);
            // withdrawAmount(AryanBank);
            // getTransactions(AryanBank);

        }
        public static void newacc(IBankRepository AryanBank)
        {
            System.Console.WriteLine("Enter account details: ");
            System.Console.WriteLine("Enter Account Number: ");
            int accno = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Enter Name : ");
            string? name = System.Console.ReadLine();
            System.Console.WriteLine("Enter Address : ");
            string? address = System.Console.ReadLine();
            System.Console.WriteLine("Enter Initial Balance: ");
            decimal bal = Convert.ToDecimal(System.Console.ReadLine());
            AryanSbaccount newAccount = new AryanSbaccount
                        {
                            AccountNumber = accno,
                            CustomerName = name,
                            CustomerAddress = address,
                            CurrentBalance = bal
                        };
            AryanBank.NewAccount(newAccount);
        }
        public static void displayaccs(IBankRepository AryanBank)
        {
            AryanBank.DisplayAccounts();
        }
        public static void getDetails(IBankRepository AryanBank)
        {
            System.Console.WriteLine("Enter your account number: ");
            int accno = Convert.ToInt32(Console.ReadLine());
            AryanSbaccount? account =AryanBank.GetDetails(accno);
            if (account!= null)
            {
                System.Console.WriteLine($"Account Number: {account.AccountNumber} Account Holder Name: {account.CustomerName}, Account Balance : {account.CurrentBalance}, Address: {account.CustomerAddress}");
            }
        }
        public static void getAllAccounts(IBankRepository AryanBank)
        {
            List<AryanSbaccount>AllAccounts = new List<AryanSbaccount>();
            AllAccounts = AryanBank.GetAllAccounts();
            foreach(var account in AllAccounts)
            {
                System.Console.WriteLine($"Account Number: {account.AccountNumber} Account Holder Name: {account.CustomerName}, Account Balance : {account.CurrentBalance}, Address: {account.CustomerAddress}");
            }
        }
        public static void depositAmount(IBankRepository AryanBank)
        {
            System.Console.WriteLine("Enter your account number: ");
            int accno = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter The amount you wish to deposit: ");
            decimal amt = Convert.ToDecimal(Console.ReadLine());
            decimal updatedBal = AryanBank.DepositAmount(accno, amt);
            System.Console.WriteLine("Updated Balance = "+updatedBal);
        }
         public static void withdrawAmount(IBankRepository AryanBank)
        {
            System.Console.WriteLine("Enter your account number: ");
            int accno = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter The amount you wish to deposit: ");
            decimal amt = Convert.ToDecimal(Console.ReadLine());
            decimal updatedBal = AryanBank.WithdrawAmount(accno, amt);
            System.Console.WriteLine("Updated Balance = "+updatedBal);
        }
        public static void getTransactions(IBankRepository AryanBank)
        {
            System.Console.WriteLine("Enter your account number to see transactions: ");
            int accno = Convert.ToInt32(Console.ReadLine());
            List<AryanSbtransaction> transactions = new List<AryanSbtransaction>();
            transactions = AryanBank.GetTransactions(accno);
            foreach(AryanSbtransaction transaction in transactions)
            {
                System.Console.WriteLine($"Transactiond ID: {transaction.TransactionId}, Account Number: {transaction.AccountNumber}, Transaction Date: {transaction.TransactionDate}, Transaction Amount: {transaction.Amount}, Transaction Type: {transaction.TransactionType}");
            }
        }
    }
}