﻿using Company.Core.Entities;
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
        public string CallNumber { get; set; }
        public string CallNumber2 { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }

        public Organization Company { get; set; }
        public Department Department { get; set; }
        public string Title { get; set; }
        public string FixedSalary { get; set; }
        public Currency Currency { get; set; }
    }
}