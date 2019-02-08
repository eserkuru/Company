using Company.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Concrete.Accounting
{
    public class AccountAddress : BaseEntity
    {
        /// <summary>
        /// Gets or sets the Current Account identifier
        /// </summary>
        public virtual Account Account { get; set; }


        /// <summary>
        /// Gets or sets the Current Address identifier
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the Current Town identifier
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// Gets or sets the Current City identifier
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the Current Country identifier
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the Current ZIP identifier
        /// </summary>
        public string ZIP { get; set; }

        
    }
}
