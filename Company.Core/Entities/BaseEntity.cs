using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;

namespace Company.Core.Entities
{
    /// <summary>
    /// Base class for entities
    /// </summary>
    public abstract class BaseEntity : IEntity
    {

        private Guid _id { get; set; }
        private string _created { get; set; }
        private string _createdBy { get; set; }
        private string _modified { get; set; }
        private string _modifiedBy { get; set; }
        private bool _isDeleted { get; set; }


        #region Properties
        #endregion

        #region Custom Properties
        /// <summary>
        /// Gets or sets the entity identifier
        /// </summary>
        [Key]
        public Guid Id
        {
            get
            {
                if (this._id == Guid.Empty)
                {
                    this._id = Guid.NewGuid();
                }
                return this._id;
            }
            set => this._id = value;
        }

        /// <summary>
        /// Gets or sets the entity created time
        /// </summary>
        public string Created
        {
            get
            {
                if (string.IsNullOrEmpty(this._created))
                {
                    this._created = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd'T'HH:mm:ss.fffK", CultureInfo.InvariantCulture);
                }
                return this._created;
            }
            set => this._created = value;

        }

        /// <summary>
        /// Gets or sets the entity created by
        /// </summary>
        public string CreatedBy
        {
            get
            {
                if (this._createdBy == null)
                {
                    this._createdBy = "Default User";
                }
                return this._createdBy;
            }
            set => this._createdBy = value;
        }

        /// <summary>
        /// Gets or sets the entity modified time
        /// </summary>
        public string Modified
        {
            get
            {
                this._modified = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd'T'HH:mm:ss.fffK", CultureInfo.InvariantCulture);
                return this._modified;
            }
            set => this._modified = value;
        }

        /// <summary>
        /// Gets or sets the entity modified by
        /// </summary>
        public string ModifiedBy
        {
            get
            {
                if (this._modifiedBy == null)
                {
                    this._modifiedBy = "Default User";
                }
                return this._modifiedBy;
            }
            set => this._modifiedBy = value;
        }

        /// <summary>
        /// Gets or sets the entity is deleted
        /// </summary>
        public bool IsDeleted
        {
            get
            {
                this._isDeleted = false;
                return this._isDeleted;
            }
            set => this._isDeleted = value;
        }
        #endregion
    }
}
