using Company.Core.Entities.Address;
using Company.Manager.Entities.Concrete.Admin;
using Microsoft.EntityFrameworkCore;

namespace Company.Manager.DataAccess.Concrete.Contexts
{
    public class ManagerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=Manager;Integrated Security=True;MultipleActiveResultSets=True");
        }

        #region Admin
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<CustomerContact> CustomerContacts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductTierPrice> ProductTierPrices { get; set; }

        #endregion

        #region Helpdesk

        #endregion

        #region Store

        #endregion

        #region Wiki

        #endregion

    }
}

