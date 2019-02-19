using Company.Core.Entities;
using Company.Project.Entities.Concrete.Accounting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Concrete.ClientManagment
{
    /// <summary>
    /// Represents a document
    /// </summary>
    public class Document : BaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// Gets or sets the client
        /// </summary>
        public virtual Client Client { get; set; }

        #endregion
    }
}
