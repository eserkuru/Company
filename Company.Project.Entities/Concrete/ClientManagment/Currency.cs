using Company.Core.Entities;
using Company.Project.Entities.Concrete.Accounting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Concrete.ClientManagment
{
    /// <summary>
    /// Represents a currency
    /// </summary>
    public class Currency : BaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the symbol
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or sets the exchange rate
        /// </summary>
        public string ExchangeRate { get; set; }
        
        #endregion

        #region Navigation Properties

        /// <summary>
        /// Gets or sets the client
        /// </summary>
        public virtual Client Client { get; set; }

        #endregion
    }
}
