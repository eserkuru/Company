using Company.Core.Entities;
using Company.Project.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Concrete.Accounting
{
    /// <summary>
    /// Represents an account address
    /// </summary>
    public class AccountAddress : Address
    {

        #region Properties

        /// Comes from the base class
        /// string  : Description
        /// string  : PostalCode
        /// Country : Country
        /// City    : City
        /// Town    : Town

        #endregion

        #region Navigation Properties

        /// <summary>
        /// Gets or sets the account
        /// </summary>
        public virtual Account Account { get; set; }

        #endregion

    }
}
