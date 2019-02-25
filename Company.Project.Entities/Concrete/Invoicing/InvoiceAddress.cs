using Company.Project.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Concrete.Invoicing
{
    public class InvoiceAddress : Address
    {
        #region Properties

        #endregion

        #region Navigation Properties

        /// <summary>
        /// Gets or sets the invoice
        /// </summary>
        public virtual Invoice Invoice { get; set; }

        #endregion
    }
}
