using Company.Core.Entities;

namespace Company.Project.Entities.Concrete.Admin
{
    /// <summary>
    /// Represents a document
    /// </summary>
    public class Document : BaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// Gets or sets the client
        /// </summary>
        public virtual Client Client { get; set; }

        #endregion
    }
}
