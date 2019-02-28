using Company.Core.Entities;
using Company.Manager.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Manager.Entities.Abstract
{
    /// <summary>
    /// Represents a contact
    /// </summary>
    public abstract class Contact : BaseEntity
    {

        #region Properties

        /// <summary>
        /// Gets or sets the contact type
        /// </summary>
        public ContactType ContactType { get; set; }

        /// <summary>
        /// Gets or sets the phone number type
        /// </summary>
        public NumberType NumberType { get; set; }

        /// <summary>
        /// Gets or sets the value
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the primary
        /// </summary>
        public bool Primary { get; set; }

        #endregion


        #region Navigation Properties

        /// No relation properties

        #endregion

        #region Custom Properties

        #endregion

    }
}
