using Company.Core.Entities;
using Company.Project.Entities.Concrete.Nearby;
using System;

namespace Company.Project.Entities.Concrete.Remote
{
    public class Account : BaseEntity
    {
        public Client Client { get; set; }

        public string Owner { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ClosingDate { get; set; }
    }
}
