using System.Collections.Generic;
using StrategyDesignPattern.Entities.Base;
using StrategyDesignPattern.Entities.Entity;

namespace StrategyDesignPattern.Entities.Message.Query
{
    public class InvoiceDetailMessage : IRequestMessage
    {
        public List<Invoice> Type { get; set; }
    }
}
