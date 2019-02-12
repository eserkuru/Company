using Company.Core.Entities;
using Company.Manager.Entities.Concrete.CRM;
using System;

namespace Company.Project.Entities.Concrete.ClientManagment
{
    public class Client : BaseEntity
    {
        /// <summary>
        /// Gets or sets the Current ClientNumber identifier
        /// </summary>
        public int ClientNumber { get; set; }

        /// <summary>
        /// Gets or sets the Current Owner identifier
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// Gets or sets the Current CreatedDate identifier
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the Current ClosingDate identifier
        /// </summary>
        public DateTime ClosingDate { get; set; }
    }
}
