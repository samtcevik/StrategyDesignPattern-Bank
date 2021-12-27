using System;
using System.Collections.Generic;
using System.Text;
using StrategyDesignPattern.Entities.Message.Query;

namespace StrategyDesignPattern.Operations.Query
{
    public class GetCompaniesAction : BaseAction
    {
        public override void Execute()
        {
            var msg = Request as CompanyListMessage;
            Console.WriteLine("GetCompaniesAction Çalıştırıldı");

            //Burada GetCompaniesAction ile ilgili operasyon kodları yazılır.

        }
    }
}
