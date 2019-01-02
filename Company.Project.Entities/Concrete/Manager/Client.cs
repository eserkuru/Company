using Company.Core.Entities;
using System;

namespace Company.Project.Entities.Concrete.Manager
{
    public class Client : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TaxNumber { get; set; }
        public string TaxOffice { get; set; }
        public string InvoiceTitle { get; set; }
        public string BillingAddress { get; set; }
        public string Town { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Email { get; set; }
    }
}
