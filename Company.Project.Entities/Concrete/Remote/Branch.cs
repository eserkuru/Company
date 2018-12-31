using Company.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Concrete.Remote
{
    public class Branch : BaseEntity
    {
        public Organisation Organisation{ get; set; }

        public string Name { get; set; }
        public string BillingAddress { get; set; }
        public string Town { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Email { get; set; }
    }
}
