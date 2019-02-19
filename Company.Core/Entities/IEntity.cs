using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Core.Entities
{
    public interface IEntity
    {
        /// <summary>
        /// Gets or sets the entity identifier
        /// </summary>
        Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the entity's Created field
        /// </summary>
        string Created { get; set; }

        /// <summary>
        /// Gets or sets the entity's Created By field
        /// </summary>
        string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the entity's Modified field
        /// </summary>
        string Modified { get; set; }

        /// <summary>
        /// Gets or sets the entity's Modified By field
        /// </summary>
        string ModifiedBy { get; set; }

        /// <summary>
        /// Gets or sets the entity's IsDeleted field
        /// </summary>
        bool IsDeleted { get; set; }
    }
}
