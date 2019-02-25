﻿// <auto-generated />
using System;
using Company.Manager.DataAccess.Concrete.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Company.Manager.DataAccess.Migrations
{
    [DbContext(typeof(ManagerContext))]
    partial class ManagerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Company.Core.Entities.Address.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("CountryCode");

                    b.Property<Guid?>("CountryId");

                    b.Property<string>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("Company.Core.Entities.Address.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("Company.Core.Entities.Address.Town", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CityCode");

                    b.Property<Guid?>("CityId");

                    b.Property<string>("Code");

                    b.Property<string>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Town");
                });

            modelBuilder.Entity("Company.Manager.Entities.Concrete.Admin.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("Name");

                    b.Property<Guid?>("ParentCategoryId");

                    b.HasKey("Id");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Company.Manager.Entities.Concrete.Admin.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Company");

                    b.Property<string>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<int>("CustomerType");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastName");

                    b.Property<string>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("NationalityId");

                    b.Property<Guid?>("NationalityId1");

                    b.Property<string>("TaxNumber");

                    b.Property<string>("TaxOffice");

                    b.HasKey("Id");

                    b.HasIndex("NationalityId1");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Company.Manager.Entities.Concrete.Admin.CustomerAddress", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CityId");

                    b.Property<Guid?>("CountryId");

                    b.Property<string>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<Guid?>("CustomerId");

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("PostalCode");

                    b.Property<Guid?>("TownId");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("TownId");

                    b.ToTable("CustomerAddresses");
                });

            modelBuilder.Entity("Company.Manager.Entities.Concrete.Admin.CustomerContact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<Guid?>("CustomerId");

                    b.Property<string>("Email");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("PhoneNumber");

                    b.Property<int>("PhoneNumberType");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerContacts");
                });

            modelBuilder.Entity("Company.Manager.Entities.Concrete.Admin.Manufacturer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("Company.Manager.Entities.Concrete.Admin.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AdditionalShippingCharge");

                    b.Property<DateTime?>("AvailableEndDateTimeUtc");

                    b.Property<DateTime?>("AvailableStartDateTimeUtc");

                    b.Property<bool>("CallForPrice");

                    b.Property<string>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<int>("DisplayOrder");

                    b.Property<int?>("DownloadExpirationDays");

                    b.Property<int>("DownloadId");

                    b.Property<string>("FullDescription");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsDownload");

                    b.Property<bool>("IsFreeShipping");

                    b.Property<bool>("IsShipEnabled");

                    b.Property<bool>("IsTaxExempt");

                    b.Property<bool>("MarkAsNew");

                    b.Property<DateTime?>("MarkAsNewEndDateTimeUtc");

                    b.Property<DateTime?>("MarkAsNewStartDateTimeUtc");

                    b.Property<int>("MaxNumberOfDownloads");

                    b.Property<string>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("Name");

                    b.Property<decimal>("OldPrice");

                    b.Property<Guid?>("ParentGroupedProductIdId");

                    b.Property<decimal>("Price");

                    b.Property<decimal>("ProductCost");

                    b.Property<int>("ProductType");

                    b.Property<int>("ProductTypeId");

                    b.Property<bool>("Published");

                    b.Property<bool>("ShipSeparately");

                    b.Property<string>("ShortDescription");

                    b.Property<string>("Sku");

                    b.Property<int>("TaxCategoryId");

                    b.Property<bool>("UnlimitedDownloads");

                    b.HasKey("Id");

                    b.HasIndex("ParentGroupedProductIdId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Company.Manager.Entities.Concrete.Admin.ProductTierPrice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("EndDateTimeUtc");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.Property<decimal>("Price");

                    b.Property<Guid?>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<DateTime?>("StartDateTimeUtc");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductTierPrices");
                });

            modelBuilder.Entity("Company.Core.Entities.Address.City", b =>
                {
                    b.HasOne("Company.Core.Entities.Address.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");
                });

            modelBuilder.Entity("Company.Core.Entities.Address.Town", b =>
                {
                    b.HasOne("Company.Core.Entities.Address.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");
                });

            modelBuilder.Entity("Company.Manager.Entities.Concrete.Admin.Category", b =>
                {
                    b.HasOne("Company.Manager.Entities.Concrete.Admin.Category", "ParentCategory")
                        .WithMany()
                        .HasForeignKey("ParentCategoryId");
                });

            modelBuilder.Entity("Company.Manager.Entities.Concrete.Admin.Customer", b =>
                {
                    b.HasOne("Company.Core.Entities.Address.Country", "Nationality")
                        .WithMany()
                        .HasForeignKey("NationalityId1");
                });

            modelBuilder.Entity("Company.Manager.Entities.Concrete.Admin.CustomerAddress", b =>
                {
                    b.HasOne("Company.Core.Entities.Address.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("Company.Core.Entities.Address.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("Company.Manager.Entities.Concrete.Admin.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("Company.Core.Entities.Address.Town", "Town")
                        .WithMany()
                        .HasForeignKey("TownId");
                });

            modelBuilder.Entity("Company.Manager.Entities.Concrete.Admin.CustomerContact", b =>
                {
                    b.HasOne("Company.Manager.Entities.Concrete.Admin.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("Company.Manager.Entities.Concrete.Admin.Product", b =>
                {
                    b.HasOne("Company.Manager.Entities.Concrete.Admin.Product", "ParentGroupedProductId")
                        .WithMany()
                        .HasForeignKey("ParentGroupedProductIdId");
                });

            modelBuilder.Entity("Company.Manager.Entities.Concrete.Admin.ProductTierPrice", b =>
                {
                    b.HasOne("Company.Manager.Entities.Concrete.Admin.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });
#pragma warning restore 612, 618
        }
    }
}
