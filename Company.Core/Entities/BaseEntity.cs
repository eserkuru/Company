using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Company.Core.Entities
{
    public abstract class BaseEntity : IEntity
    {
        [Key]
        public Guid Id
        {
            get => Id == null ? Guid.NewGuid() : Id;
            set => Id = value;
        }

        public DateTime Created
        {
            get => Created == null ? DateTime.Now : Created;
            set => Created = value;
        }
        public string CreatedBy
        {
            get => CreatedBy == null ? "test" : CreatedBy;
            set => CreatedBy = value;
        }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
