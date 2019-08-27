﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VersionManagement.Models;

namespace VersionManagement.Migrations
{
    [DbContext(typeof(VManagementContext))]
    [Migration("20190827101742_FourthMigration")]
    partial class FourthMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VersionManagement.Models.ChangeLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<Guid?>("ChangeLogTypeId");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<string>("Title");

                    b.Property<Guid?>("VersionId");

                    b.HasKey("Id");

                    b.HasIndex("ChangeLogTypeId");

                    b.HasIndex("VersionId");

                    b.ToTable("ChangeLog");
                });

            modelBuilder.Entity("VersionManagement.Models.ChangeLogType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ChangeLogType");
                });

            modelBuilder.Entity("VersionManagement.Models.Component", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<Guid?>("ProductId");

                    b.Property<Guid?>("ProductId1");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductId1");

                    b.ToTable("Component");
                });

            modelBuilder.Entity("VersionManagement.Models.ComponentType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ComponentType");
                });

            modelBuilder.Entity("VersionManagement.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("VersionManagement.Models.CustomerProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<Guid?>("CustomerId");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<Guid?>("LastVersionId");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<Guid?>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("LastVersionId");

                    b.HasIndex("ProductId");

                    b.ToTable("CustomerProduct");
                });

            modelBuilder.Entity("VersionManagement.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("VersionManagement.Models.PublishActivity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<Guid?>("CustomerProductId");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<Guid?>("VersionId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerProductId");

                    b.HasIndex("VersionId");

                    b.ToTable("PublishActivity");
                });

            modelBuilder.Entity("VersionManagement.Models.Version", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("Comment");

                    b.Property<Guid?>("ComponentId");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<string>("ReleaseNumber");

                    b.HasKey("Id");

                    b.HasIndex("ComponentId");

                    b.ToTable("Version");
                });

            modelBuilder.Entity("VersionManagement.Models.ChangeLog", b =>
                {
                    b.HasOne("VersionManagement.Models.ChangeLogType", "ChangeLogType")
                        .WithMany()
                        .HasForeignKey("ChangeLogTypeId");

                    b.HasOne("VersionManagement.Models.Version", "Version")
                        .WithMany()
                        .HasForeignKey("VersionId");
                });

            modelBuilder.Entity("VersionManagement.Models.Component", b =>
                {
                    b.HasOne("VersionManagement.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("VersionManagement.Models.Product")
                        .WithMany("Components")
                        .HasForeignKey("ProductId1");
                });

            modelBuilder.Entity("VersionManagement.Models.CustomerProduct", b =>
                {
                    b.HasOne("VersionManagement.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("VersionManagement.Models.Version", "LastVersion")
                        .WithMany()
                        .HasForeignKey("LastVersionId");

                    b.HasOne("VersionManagement.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("VersionManagement.Models.PublishActivity", b =>
                {
                    b.HasOne("VersionManagement.Models.CustomerProduct", "CustomerProduct")
                        .WithMany()
                        .HasForeignKey("CustomerProductId");

                    b.HasOne("VersionManagement.Models.Version", "Version")
                        .WithMany()
                        .HasForeignKey("VersionId");
                });

            modelBuilder.Entity("VersionManagement.Models.Version", b =>
                {
                    b.HasOne("VersionManagement.Models.Component", "Component")
                        .WithMany("Versions")
                        .HasForeignKey("ComponentId");
                });
#pragma warning restore 612, 618
        }
    }
}
