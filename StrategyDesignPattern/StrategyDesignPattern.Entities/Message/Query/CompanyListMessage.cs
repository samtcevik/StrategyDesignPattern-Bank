using System.Collections.Generic;
using StrategyDesignPattern.Entities.Base;
using StrategyDesignPattern.Entities.Entity;

namespace StrategyDesignPattern.Entities.Message.Query
{
    public class CompanyListMessage : RequestMessage
    {
        public List<Company> Type { get; set; }
    }
}
