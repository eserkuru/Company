﻿using Company.Core.Entities;
using Company.Project.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Concrete.Admin
{
    /// <summary>
    /// Represents a branch contact
    /// </summary>
    public class BranchContact : Contact
    {
        #region Properties

        /// Comes from the base class
        /// PhoneNumberType  : PhoneNumberType
        /// string           : PhoneNumber
        /// string           : EMail

        #endregion

        #region Navigation Properties

        /// <summary>
        /// Gets or sets the branch
        /// </summary>
        public virtual Branch Branch { get; set; }

        #endregion
    }
}
