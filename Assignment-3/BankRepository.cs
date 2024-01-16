using BankRep.Models;

namespace BankRep
{
    public class BankRepository: IBankRepository
    {
        int transactionCounter = 1;
        static Ace52024Context db = new Ace52024Context();
        
        public void NewAccount(AryanSbaccount acc)
        {
            db.AryanSbaccounts.Add(acc);
            db.SaveChanges();
            System.Console.WriteLine("ACCOUNT ADDED SUCCESSFULLY!!");
        }
        public void DisplayAccounts()
        {
            foreach (var item in db.AryanSbaccounts)
            {
                System.Console.WriteLine($"Account Number: {item.AccountNumber}, Name: {item.CustomerName}, Address: {item.CustomerAddress}, Available Balance: {item.CurrentBalance}");
            }
        }
        public AryanSbaccount GetDetails(int accno)
        {
            AryanSbaccount account = db.AryanSbaccounts.Where(x => x.AccountNumber == accno).FirstOrDefault();
            if(account == null)
            {
                System.Console.WriteLine("No such account exists!!");
                throw new InvalidOperationException("Account NOT found!");
            }
            else
            {
                return account;
            }
        }
        public List<AryanSbaccount> GetAllAccounts()
        {
            List<AryanSbaccount> accounts = new List<AryanSbaccount>();
            accounts = db.AryanSbaccounts.ToList();
            return accounts;
        }
        public decimal DepositAmount(int accno, decimal amt)
        {
            AryanSbaccount account = GetDetails(accno);
            account.CurrentBalance +=amt;
            AryanSbtransaction transaction = new AryanSbtransaction{
                                                                    AccountNumber = accno,
                                                                    Amount = amt,
                                                                    TransactionId = transactionCounter++,
                                                                    TransactionDate = DateOnly.FromDateTime(DateTime.Now),
                                                                    TransactionType = "Deposit"
                                                                    };
            db.AryanSbtransactions.Add(transaction);
            db.SaveChanges();
            System.Console.WriteLine("The amount is successfully deposited!!");
            return (decimal)account.CurrentBalance;
        }
        public decimal WithdrawAmount(int accno, decimal amt)
        {
            AryanSbaccount account = GetDetails(accno);
            if (account.CurrentBalance < amt)
            {
                throw new InvalidOperationException("Insufficient Balance!");
            }
            account.CurrentBalance = account.CurrentBalance - amt;
            AryanSbtransaction transaction = new AryanSbtransaction{
                                                                    AccountNumber = accno,
                                                                    Amount = amt,
                                                                    TransactionId = transactionCounter++,
                                                                    TransactionDate = DateOnly.FromDateTime(DateTime.Now),
                                                                    TransactionType = "Withdraw"
                                                                    };
            db.AryanSbtransactions.Add(transaction);
            db.SaveChanges();
            System.Console.WriteLine("The amount is successfully deposited!!");
            return (decimal)account.CurrentBalance;
        }
        public List<AryanSbtransaction> GetTransactions(int accno)
        {
            List<AryanSbtransaction> transactions = new List<AryanSbtransaction>();
            transactions = db.AryanSbtransactions.Where(x=>x.AccountNumber == accno).ToList();
            return transactions;
        }

    }
}