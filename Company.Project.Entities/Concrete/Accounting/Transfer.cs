using Company.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Concrete.Accounting
{
    /// <summary>
    /// Represents an account
    /// </summary>
    public class Transfer : BaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the amount
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the transfer time
        /// </summary>
        public DateTime TransferTime { get; set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// Gets or sets the account
        /// </summary>
        public Account Account { get; set; }

        /// <summary>
        /// Gets or sets the target account
        /// </summary>
        public Account TargetAccount { get; set; }

        #endregion
    }
}
