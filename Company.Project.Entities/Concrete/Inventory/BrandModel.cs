using Company.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Concrete.Inventory
{
    public class BrandModel : BaseEntity
    {
        /// <summary>
        /// Gets or sets the Current Brand identifier
        /// </summary>
        public virtual Brand Brand { get; set; }
    }
}
