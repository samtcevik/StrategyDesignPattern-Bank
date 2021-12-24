using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using StrategyDesignPattern.Entities.Base;

namespace StrategyDesignPattern.Operations
{
    public abstract class BaseAction
    {
        public IRequestMessage Request { get; set; }

        public abstract void Execute();


    }
}
