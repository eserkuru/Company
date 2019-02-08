using Company.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Abstract
{
    public abstract class Contact : BaseEntity
    {
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
