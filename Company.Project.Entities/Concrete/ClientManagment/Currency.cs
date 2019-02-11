using Company.Core.Entities;
using Company.Project.Entities.Concrete.Accounting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Concrete.ClientManagment
{
    public class Currency : BaseEntity
    {
        public virtual Client Client { get; set; }

        /// <summary>
        /// Gets or sets the Current Name identifier
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Current Code identifier
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the Current Symbol identifier
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or sets the Current ExchangeRate identifier
        /// </summary>
        public string ExchangeRate { get; set; }
    }
}
