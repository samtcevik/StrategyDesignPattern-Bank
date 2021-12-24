using System.Collections.Generic;
using StrategyDesignPattern.Entities.Base;
using StrategyDesignPattern.Entities.Entity;

namespace StrategyDesignPattern.Entities.Message.Query
{
    public class CompanyListMessage : IRequestMessage
    {
        public List<Company> Type { get; set; }
    }
}
