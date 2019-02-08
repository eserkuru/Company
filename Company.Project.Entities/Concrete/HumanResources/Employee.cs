using Company.Core.Entities;
using Company.Project.Entities.Concrete.ClientManagment;
using System;

namespace Company.Project.Entities.Concrete.HumanResources
{
    public class Employee : BaseEntity
    {
        public Organisation Organisation { get; set; }
        public Branch Branch { get; set; }
        public Unit Units { get; set; }

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

        public string Title { get; set; }
        public string FixedSalary { get; set; }
        public Currency Currency { get; set; }
        public DateTime ContractStartDate { get; set; }
        public DateTime ContractEndDate { get; set; }
    }
}
