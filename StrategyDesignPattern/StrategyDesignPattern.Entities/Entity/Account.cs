using System;

namespace StrategyDesignPattern.Entities.Entity
{
    [Serializable]
    public class Account : IEntity
    {
        public long AccountNumber { get; set; }
        public long AccountName { get; set; }
        public int BranchCode { get; set; }
        public string BranchName { get; set; }
        public int Suffix { get; set; }
        public string ProductCode { get; set; }
        public string CurrencyCode { get; set; }
        public string Iban { get; set; }
        public decimal Balance { get; set; }
        public decimal AvailableBalance { get; set; }
        public bool IsClosed { get; set; }
    }
}
