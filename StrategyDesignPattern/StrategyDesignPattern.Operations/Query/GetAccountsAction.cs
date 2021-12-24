using System;
using System.Threading;
using StrategyDesignPattern.Entities.Message.Query;

namespace StrategyDesignPattern.Operations.Query
{
    public class GetAccountsAction : BaseAction
    {
        public override void Execute()
        {
            var message = Request as AccountListMessage;
            Console.WriteLine("GetAccountsAction Çalıştırıldı");
        }
    }
}
