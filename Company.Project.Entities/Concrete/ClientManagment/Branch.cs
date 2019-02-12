using Company.Core.Entities;
using Company.Project.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Concrete.ClientManagment
{
    public class Branch : BaseEntity
    {
        /// <summary>
        /// Gets or sets the Current Name identifier
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Current Description identifier
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the Current Town identifier
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// Gets or sets the Current City identifier
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the Current Country identifier
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the Current PostalCode identifier
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the Current Organisation identifier
        /// </summary>
        public Organisation Organisation { get; set; }
    }
}
