using Company.Core.Entities;
using Company.Project.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Concrete.Accounting
{
    /// <summary>
    /// Represents an account contact
    /// </summary>
    public class AccountContact : Contact
    {

        #region Properties

        /// Comes from the base class
        /// PhoneNumberType  : PhoneNumberType
        /// string           : PhoneNumber
        /// string           : EMail

        #endregion

        #region Navigation Properties

        /// <summary>
        /// Gets or sets the account
        /// </summary>
        public virtual Account Account { get; set; }

        #endregion

    }
}
