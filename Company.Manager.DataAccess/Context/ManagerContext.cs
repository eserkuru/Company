using Company.Manager.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Company.Manager.DataAccess.Concrete.Contexts
{
    public class ManagerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=Manager;Integrated Security=True;MultipleActiveResultSets=True");
        }

        public DbSet<Customer> Customers { get; set; }
    }
}

