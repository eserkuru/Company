using Company.Project.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.DataAccess.Concrete.Contexts
{
    class ProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Project; Trusted_Connection=true");
        }

        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Organization> Organizations{ get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees{ get; set; }
        public DbSet<User> Users { get; set; }
    }
}
