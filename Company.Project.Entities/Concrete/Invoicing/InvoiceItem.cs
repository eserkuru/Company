using Company.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Concrete.Invoicing
{
    public class InvoiceItem : BaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the quantity
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the unit price (include tax)
        /// </summary>
        public decimal UnitPriceInclTax { get; set; }

        /// <summary>
        /// Gets or sets the unit price (exclude tax)
        /// </summary>
        public decimal UnitPriceExclTax { get; set; }

        /// <summary>
        /// Gets or sets the price (include tax)
        /// </summary>
        public decimal PriceInclTax { get; set; }

        /// <summary>
        /// Gets or sets the price (exclude tax)
        /// </summary>
        public decimal PriceExclTax { get; set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// Gets or sets the invoice
        /// </summary>
        public virtual Invoice Invoice { get; set; }

        #endregion
    }
}
