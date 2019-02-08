using Company.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Manager.Entities.Abstract
{
    public abstract class Address : BaseEntity
    {
        public string Description { get; set; }
        public string Town { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ZIP { get; set; }
    }
}
