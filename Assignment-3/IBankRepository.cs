using BankRep.Models;

namespace BankRep
{
    public interface IBankRepository
    {
        void NewAccount(AryanSbaccount account);
        // List <AryanSbaccount>GetAllAccounts();
        void DisplayAccounts();
        AryanSbaccount? GetDetails(int accno);
        List<AryanSbaccount> GetAllAccounts();
        decimal DepositAmount(int accno, decimal amt);
        decimal WithdrawAmount(int accno, decimal amt);
        List<AryanSbtransaction> GetTransactions(int accno);
    }
}
