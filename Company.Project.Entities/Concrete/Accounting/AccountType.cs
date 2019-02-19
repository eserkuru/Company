using Company.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Concrete.Accounting
{

    /// <summary>
    /// Represents an account type
    /// </summary>
    public class AccountType : BaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the type name
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// Gets or sets the type Code
        /// </summary>
        public string TypeCode { get; set; }

        #endregion

        #region Navigation Properties

        /// No relation properties

        #endregion
    }
}
