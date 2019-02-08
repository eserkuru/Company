using Company.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Concrete.ClientManagment
{
    public class Branch : BaseEntity
    {
        /// <summary>
        /// Gets or sets the Current Name identifier
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Current Organisation identifier
        /// </summary>
        public Organisation Organisation{ get; set; }
    }
}
