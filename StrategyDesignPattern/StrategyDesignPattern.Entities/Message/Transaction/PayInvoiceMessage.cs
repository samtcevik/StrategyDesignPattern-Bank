using System;
using System.Collections.Generic;
using System.Text;
using StrategyDesignPattern.Entities.Base;

namespace StrategyDesignPattern.Entities.Message.Transaction
{
    public class PayInvoiceMessage : RequestMessage
    {
        public int Id { get; set; }
        public DateTime PaymentDueDate { get; set; }
        public decimal PaymentAmount { get; set; }
        public string CurrencyCode { get; set; }
    }
}
