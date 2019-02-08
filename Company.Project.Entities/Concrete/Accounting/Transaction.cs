using Company.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Concrete.Accounting
{
    public class Transaction : BaseEntity
    {

        /// <summary>
        /// Gets or sets the Current Account identifier
        /// </summary>
        public virtual Account Account { get; set; }
    }
}
