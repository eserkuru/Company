﻿using Company.Core.Entities;
using Company.Project.Entities.Abstract;
using Company.Project.Entities.Concrete.ClientManagment;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Concrete.Invoicing
{
    public class Invoice : BaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the total unit price (include tax)
        /// </summary>
        public decimal TotalUnitPriceInclTax { get; set; }

        /// <summary>
        /// Gets or sets the total unit price (exclude tax)
        /// </summary>
        public decimal TotalUnitPriceExclTax { get; set; }

        /// <summary>
        /// Gets or sets the total price (include tax)
        /// </summary>
        public decimal TotalPriceInclTax { get; set; }

        /// <summary>
        /// Gets or sets the total price (exclude tax)
        /// </summary>
        public decimal TotalPriceExclTax { get; set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// Gets or sets the organisation
        /// </summary>
        public virtual Organisation Organisation { get; set; }

        /// <summary>
        /// Gets or sets the address
        /// </summary>
        public virtual Address Address { get; set; }

        #endregion
    }
}
