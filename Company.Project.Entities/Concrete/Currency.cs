using Company.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Concrete
{
    public class Currency : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Symbol { get; set; }
        public string ExchangeRate { get; set; }
    }
}
