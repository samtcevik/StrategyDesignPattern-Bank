using System;
using System.Collections.Generic;
using System.Text;
using StrategyDesignPattern.Entities.Message.Transaction;

namespace StrategyDesignPattern.Operations.Transaction
{
    public class PayInvoiceAction : BaseAction
    {
        public override void Execute()
        {
            var msg = Request as PayInvoiceMessage;
            Console.WriteLine("PayInvoiceAction Çalıştırıldı");
        }
    }
}
