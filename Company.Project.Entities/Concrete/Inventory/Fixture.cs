using Company.Core.Entities;
using Company.Project.Entities.Concrete.ClientManagment;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Concrete.Inventory
{
    public class Fixture : BaseEntity
    {
        public virtual Organisation Organisation { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual BrandModel BrandModel { get; set; }
    }
}
