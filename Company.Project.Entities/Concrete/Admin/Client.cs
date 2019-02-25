using Company.Core.Entities;
using System;

namespace Company.Project.Entities.Concrete.Admin
{
    /// <summary>
    /// Represents a client
    /// </summary>
    public class Client : BaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the client number
        /// </summary>
        public int CustomerNumber { get; set; }

        /// <summary>
        /// Gets or sets the owner 
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// Gets or sets the created date 
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the closing date
        /// </summary>
        public DateTime ClosingDate { get; set; }

        /// <summary>
        /// Gets or sets the customer
        /// </summary>
        public Guid CustomerGuid { get; set; }

        #endregion

        #region Navigation Properties

        /// No relation properties

        #endregion
    }
}
