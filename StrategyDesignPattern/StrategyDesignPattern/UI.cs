using StrategyDesignPattern.Operations.Query;
using StrategyDesignPattern.Operations.Transaction;

namespace StrategyDesignPattern.UI
{
    class UI
    {
        static void Main(string[] args)
        {
            var action1 = new GetAccountsAction();
            var action2 = new GetCompaniesAction();
            var action3 = new GetInvoicesAction();
            var action4 = new PayInvoiceAction();
            var action5 = new WithDrawAction();

            action1.Execute();
            action2.Execute();
            action3.Execute();
            action4.Execute();
            action5.Execute();

        }
    }
}
