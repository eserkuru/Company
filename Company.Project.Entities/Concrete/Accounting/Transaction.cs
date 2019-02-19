using Company.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Concrete.Accounting
{
    /// <summary>
    /// Represents a transaction
    /// </summary>
    public class Transaction : BaseEntity
    {

        #region Properties

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the transaction time
        /// </summary>
        public DateTime TransactionTime { get; set; }

        /// <summary>
        /// Gets or sets the in amount
        /// </summary>
        public decimal InAmount { get; set; }

        /// <summary>
        /// Gets or sets the amount out
        /// </summary>
        public decimal AmountOut { get; set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// Gets or sets the Account
        /// </summary>
        public virtual Account Account { get; set; }

        #endregion

    }
}
