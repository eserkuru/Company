using Company.Core.Entities;
using Company.Project.Entities.Concrete.Admin;

namespace Company.Project.Entities.Concrete.HumanResources
{
    /// <summary>
    /// Represents a unit
    /// </summary>
    public class Unit : BaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        #endregion


        #region Navigation Properties

        /// <summary>
        /// Gets or sets the organisation
        /// </summary>
        public Organisation Organisation { get; set; }

        /// <summary>
        /// Gets or sets the branch
        /// </summary>
        public Branch Branch { get; set; }

        #endregion
    }
}
