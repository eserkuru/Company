using Company.Core.Entities;
using Company.Project.Entities.Concrete.ClientManagment;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Concrete.Inventory
{
    public class Fixture : BaseEntity
    {
        #region Properties

        #endregion

        #region Navigation Properties

        /// <summary>
        /// Gets or sets the organisation
        /// </summary>
        public virtual Organisation Organisation { get; set; }

        /// <summary>
        /// Gets or sets the brand
        /// </summary>
        public virtual Brand Brand { get; set; }

        /// <summary>
        /// Gets or sets the brand model
        /// </summary>
        public virtual BrandModel BrandModel { get; set; }
        
        #endregion

    }
}
