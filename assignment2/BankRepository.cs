
using System.Data;
using System.Transactions;

namespace assignment2
{
    class BankRepository : IBankRepository
    {
        List<SBAccount> accounts = new List<SBAccount>();
        List<SBTransaction> transactions = new List<SBTransaction>();
        int transactionIdCounter = 1;

        public float DepositAmount(int accno, float amt)
        {
            SBAccount account = GetAccountDetails(accno);
            account.CurrentBalance += amt;

            transactions.Add(new SBTransaction
            {
                TransactionId = transactionIdCounter++,
                TransactionDate = DateTime.Now,
                AccountNumber = accno,
                Amount = amt,
                TransactionType = "Deposit"
            });

            return account.CurrentBalance;
        }

        public SBAccount GetAccountDetails(int accno)
        {
            foreach (SBAccount item in accounts)
            {
                if (item.AccountNumber == accno)
                {
                    return item;
                }
            }
            System.Console.WriteLine("The account does not exist!");
            // return null;
            throw new InvalidOperationException("Account NOT found!");
        }

        public List<SBAccount> GetAllAccounts()
        {
            return accounts;
        }

        public List<SBTransaction> GetTransactions(int accno)
        {
            List<SBTransaction> desired = new List<SBTransaction>();
            foreach (SBTransaction item in transactions)
            {
                if (item.AccountNumber == accno)
                {
                    desired.Add(item);
                }
            }
            return desired;
        }

        public void NewAccount(SBAccount acc)
        {
            accounts.Add(acc);
        }

        public float WithdrawAmount(int accno, float amt)
        {
            var account = GetAccountDetails(accno);
            if (account.CurrentBalance < amt)
            {
                throw new InvalidOperationException("Insufficient balance.");
            }

            account.CurrentBalance -= amt;

            transactions.Add(new SBTransaction
            {
                TransactionId = transactionIdCounter++,
                TransactionDate = DateTime.Now,
                AccountNumber = accno,
                Amount = amt,
                TransactionType = "Withdraw"
            });

            return account.CurrentBalance;
        }
    }
}