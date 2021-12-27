using System;
using System.Collections.Generic;
using System.Text;
using StrategyDesignPattern.Entities.Message.Transaction;

namespace StrategyDesignPattern.Operations.Transaction
{
    public class WithDrawAction : BaseAction
    {
        public override void Execute()
        {
            var msg = Request as WithdrawMessage;
            Console.WriteLine("WithDrawAction Çalıştırıldı...");
        }
    }
}
