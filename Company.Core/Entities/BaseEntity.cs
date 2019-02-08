using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;

namespace Company.Core.Entities
{
    public abstract class BaseEntity : IEntity
    {
        private Guid _id { get; set; }
        private string _created { get; set; }
        private string _createdBy { get; set; }
        private string _modified { get; set; }
        private string _modifiedBy { get; set; }

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
        public string Modified
        {
            get
            {
                this._modified = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd'T'HH:mm:ss.fffK", CultureInfo.InvariantCulture);
                return this._modified;
            }
            set => this._modified = value;
        }
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
    }
}
