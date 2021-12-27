using System.Collections.Generic;
using StrategyDesignPattern.Entities.Base;
using StrategyDesignPattern.Entities.Entity;

namespace StrategyDesignPattern.Entities.Message.Query
{
    public class AccountListMessage : RequestMessage
    {
        public List<Account> Accounts { get; set; }
    }
}
