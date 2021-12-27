using System;
using System.Collections.Generic;
using System.Text;
using StrategyDesignPattern.Entities.Base;

namespace StrategyDesignPattern.Operations
{
    public abstract class DefaultAction //Bütün BaseActionlar DefaultAction'dan türetilmelidir.
    {
        public IRequestMessage Request { get; set; }
    }
}
