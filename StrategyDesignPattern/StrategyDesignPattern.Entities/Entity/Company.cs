using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace StrategyDesignPattern.Entities.Entity
{
    public class Company : IEntity
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public DateTime EstablishDate { get; set; }
        public string Address { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
        public decimal AnnualReturn { get; set; }
    }
}
