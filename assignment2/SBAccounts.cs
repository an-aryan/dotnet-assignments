using System;
using System.Collections.Generic;

namespace assignment2
{
    public class SBAccount
    {
        public int AccountNumber { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerAddress { get; set; }
        public float CurrentBalance { get; set; }
    }

    // SBTransaction class
    public class SBTransaction
    {
        public int TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public int AccountNumber { get; set; }
        public float Amount { get; set; }
        public string? TransactionType { get; set; } // "Deposit" or "Withdraw"
    }
}