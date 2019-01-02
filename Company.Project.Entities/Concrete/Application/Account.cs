using Company.Core.Entities;
using Company.Project.Entities.Concrete.Manager;
using System;

namespace Company.Project.Entities.Concrete.Application
{
    public class Account : BaseEntity
    {
        public Client Client { get; set; }

        public string Owner { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ClosingDate { get; set; }
    }
}
