namespace assignment2
{
    interface IBankRepository
    {
        void NewAccount(SBAccount acc);
        List<SBAccount> GetAllAccounts();
        SBAccount GetAccountDetails(int accno);
        float DepositAmount(int accno, float amt);
        float WithdrawAmount(int accno, float amt);
        List<SBTransaction> GetTransactions(int accno);
    }
}