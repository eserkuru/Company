using Company.Core.Entities;
using Company.Project.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Abstract
{
    /// <summary>
    /// Represents a contact
    /// </summary>
    public abstract class Contact : BaseEntity
    {

        #region Properties

        /// <summary>
        /// Gets or sets the phone number type
        /// </summary>
        public PhoneNumberType PhoneNumberType { get; set; }

        /// <summary>
        /// Gets or sets the phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the e-mail
        /// </summary>
        public string Email { get; set; }

        #endregion

        #region Navigation Properties

        /// No relation properties

        #endregion

        #region Status Properties

        /// <summary>
        /// Gets or sets the primary
        /// </summary>
        public bool Primary { get; set; }

        #endregion

        #region Custom Properties

        #endregion

    }
}
