using Company.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Manager.Entities.Concrete.Admin
{
    /// <summary>
    /// Represents a tier price
    /// </summary>
    public partial class ProductTierPrice : BaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the quantity
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the start date and time in UTC
        /// </summary>
        public DateTime? StartDateTimeUtc { get; set; }

        /// <summary>
        /// Gets or sets the end date and time in UTC
        /// </summary>
        public DateTime? EndDateTimeUtc { get; set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// Gets or sets the product
        /// </summary>
        public virtual Product Product { get; set; }

        #endregion
    }
}
