using Company.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Concrete.ClientManagment
{
    public class Currency : BaseEntity
    {
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
