using Company.Core.Entities;
using Company.Project.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Concrete.ClientManagment
{
    public class BranchContact : Contact
    {
        /// <summary>
        /// Gets or sets the Current Branch identifier
        /// </summary>
        public virtual Branch Branch { get; set; }
    }
}
