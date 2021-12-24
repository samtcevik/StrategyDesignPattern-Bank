using StrategyDesignPattern.Operations.Query;

namespace StrategyDesignPattern.UI
{
    class UI
    {
        static void Main(string[] args)
        {
            var action1 = new GetAccountsAction();
            var action2 = new GetCompaniesAction();
            var action3 = new GetInvoicesAction();
            
            action1.Execute();
            action2.Execute();
            action3.Execute();
        }
    }
}
