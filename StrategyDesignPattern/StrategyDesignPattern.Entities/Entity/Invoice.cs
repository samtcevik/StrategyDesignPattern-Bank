using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.Entities.Entity
{
    public class Invoice : IEntity
    {
        public int Id { get; set; }
        public string InstitutionName { get; set; }
        public DateTime PaymentDueDate { get; set; }
        public decimal PaymentAmount { get; set; }
        public string CurrencyCode { get; set; }

    }
}
