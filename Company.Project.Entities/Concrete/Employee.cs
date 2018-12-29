using Company.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Concrete
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Department Department { get; set; }
        public string Salary { get; set; }
        public Currency Currency { get; set; }
    }
}
