using System;
using System.Collections.Generic;
using System.Text;
using StrategyDesignPattern.Entities.Message.Query;

namespace StrategyDesignPattern.Operations.Query
{
    public class GetInvoicesAction : BaseAction
    {
        public override void Execute()
        {
            var message = Request as InvoiceDetailMessage;
            Console.WriteLine("GetInvoicesAction Çalıştırıldı");

            //Burada GetInvoicesAction ile ilgili operasyon kodları yazılır.

        }
    }
}
