using Company.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Abstract
{
    public abstract class Contact : BaseEntity
    {
        public PhoneNumberType PhoneNumberType { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }

    public enum PhoneNumberType
    {
        GSM = 1,
        LandPhone = 2,
        FAX = 3,
        PBX = 4
    }
}
