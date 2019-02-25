using Company.Core.Entities.Address;
using Company.Project.Entities.Concrete.Accounting;
using Company.Project.Entities.Concrete.Admin;
using Company.Project.Entities.Concrete.HumanResources;
using Company.Project.Entities.Concrete.Inventory;
using Company.Project.Entities.Concrete.Invoicing;
using Microsoft.EntityFrameworkCore;

namespace Company.Project.DataAccess.Concrete.Contexts
{
    public class ProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=Project;Integrated Security=True;MultipleActiveResultSets=True");
        }

        #region Admin

        public DbSet<Branch> Branches { get; set; }
        public DbSet<BranchContact> BranchContacts { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Configuration> Configurations { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Organisation> Organisations { get; set; }

        #endregion

        #region Accounting

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountAddress> AccountAddresses { get; set; }
        public DbSet<AccountContact> AccountContacts { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Transfer> Transfers { get; set; }

        #endregion

        #region HumanResources

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Unit> Units { get; set; }

        #endregion

        #region Inventory

        public DbSet<Brand> Brands { get; set; }
        public DbSet<BrandModel> BrandModels { get; set; }
        public DbSet<Fixture> Fixtures { get; set; }

        #endregion

        #region Invoicing

        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceAddress> InvoiceAddresses { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }

        #endregion
    }
}
