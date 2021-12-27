using System;
using System.Collections.Generic;
using System.Text;
using StrategyDesignPattern.Entities.Base;
using StrategyDesignPattern.Entities.Entity;

namespace StrategyDesignPattern.Entities.Message.Transaction
{
    public class WithdrawMessage : RequestMessage
    {
        public DateTime WithdrawDate { get; set; }
        public decimal WithdrawAmount { get; set; }
        public string CurrencyCode { get; set; }
        public Account Account { get; set; }
    }
}
