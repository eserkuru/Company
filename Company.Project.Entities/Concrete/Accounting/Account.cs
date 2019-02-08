using Company.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Concrete.Accounting
{
    public class Account : BaseEntity
    {
        public string TradeName { get; set; }
        public string TaxNumber { get; set; }
        public string TaxOffice { get; set; }
    }
}
