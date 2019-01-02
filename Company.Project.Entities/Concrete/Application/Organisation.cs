using Company.Core.Entities;
using System.Text;

namespace Company.Project.Entities.Concrete.Application
{
    public class Organisation : BaseEntity
    {
        public Account Account { get; set; }

        public string Name { get; set; }
        public string ShortName { get; set; }
        public string LogoURL { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ZIP { get; set; }
        public string TaxNumber { get; set; }
        public string TaxOffice { get; set; }
        public string InvoiceTitle { get; set; }
        public string CRSNumber { get; set; }
        public string TradeNumber { get; set; }
    }
}
