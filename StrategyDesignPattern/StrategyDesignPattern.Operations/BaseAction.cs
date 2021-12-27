using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using StrategyDesignPattern.Entities.Base;

namespace StrategyDesignPattern.Operations
{
    public abstract class BaseAction : DefaultAction
    {
        protected BaseAction()
        {
            
        }
        public new RequestMessage Request => (RequestMessage)base.Request;

        public abstract void Execute();

    }
}
