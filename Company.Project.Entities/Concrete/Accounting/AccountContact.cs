﻿using Company.Project.Entities.Abstract;

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
