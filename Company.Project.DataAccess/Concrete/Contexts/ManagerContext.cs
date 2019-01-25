using Company.Project.Entities.Concrete.Manager;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.DataAccess.Concrete.Contexts
{
    public class ManagerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=Manager;Integrated Security=True;MultipleActiveResultSets=True");
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Plan> Plans { get; set; }
    }
}

