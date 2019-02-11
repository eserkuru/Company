﻿using Company.Project.Entities.Concrete.Accounting;
using Company.Project.Entities.Concrete.ClientManagment;
using Company.Project.Entities.Concrete.HumanResources;
using Company.Project.Entities.Concrete.Inventory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.DataAccess.Concrete.Contexts
{
    public class ProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=Project;Integrated Security=True;MultipleActiveResultSets=True");
        }

        #region ClientManagment
        public DbSet<Client> Clients { get; set; }
        public DbSet<Organisation> Organisations { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<BranchAddress> BranchAddresses { get; set; }
        public DbSet<BranchContact> BranchContacts { get; set; }

        /** CFG **/
        public DbSet<Configuration> Configurations { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Document> Documents { get; set; }

        #endregion

        #region Accounting
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountAddress> AccountAddresses { get; set; }
        public DbSet<AccountContact> AccountContacts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        #endregion

        #region HumanResources
        public DbSet<Unit> Units { get; set; }
        public DbSet<Employee> Employees { get; set; }

        #endregion

        #region Inventory
        public DbSet<Brand> Brands { get; set; }
        public DbSet<BrandModel> BrandModels { get; set; }

        #endregion

    }
}