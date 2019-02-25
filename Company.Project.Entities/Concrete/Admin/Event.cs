using Company.Core.Entities;
using System;

namespace Company.Project.Entities.Concrete.Admin
{
    /// <summary>
    /// Represents an event
    /// </summary>
    public class Event : BaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the event time
        /// </summary>
        public DateTime EventTime { get; set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// Gets or sets the client
        /// </summary>
        public virtual Client Client { get; set; }

        #endregion
    }
}
