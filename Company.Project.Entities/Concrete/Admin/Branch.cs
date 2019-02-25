using Company.Core.Entities;
using Company.Project.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Concrete.Admin
{
    /// <summary>
    /// Represents a branch
    /// </summary>
    public class Branch : Address
    {

        #region  properties

        /// Comes from the base class
        /// string  : Description
        /// string  : PostalCode
        /// Country : Country
        /// City    : City
        /// Town    : Town

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        #endregion

        #region Navigation properties

        /// <summary>
        /// Gets or sets the organisation
        /// </summary>
        public Organisation Organisation { get; set; }

        #endregion
    }
}
