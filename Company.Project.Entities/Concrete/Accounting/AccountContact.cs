using Company.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Concrete.Accounting
{
    public class AccountContact : BaseEntity
    {
        /// <summary>
        /// Gets or sets the E-Mail identifier
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the Phone Number identifier
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the Current Account identifier
        /// </summary>
        public virtual Account Account { get; set; }
    }
}
