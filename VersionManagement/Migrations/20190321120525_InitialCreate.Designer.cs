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
    [DbContext(typeof(VersionDatabaseModel))]
    [Migration("20190321120525_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VersionManagement.Models.ChangeLog", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("ChangeLogTypeId");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Title");

                    b.Property<int>("TypeId");

                    b.Property<int>("VersionId");

                    b.Property<long?>("VersionId1");

                    b.HasKey("Id");

                    b.HasIndex("ChangeLogTypeId");

                    b.HasIndex("VersionId1");

                    b.ToTable("ChangeLog");
                });

            modelBuilder.Entity("VersionManagement.Models.ChangeLogType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ChangeLogType");
                });

            modelBuilder.Entity("VersionManagement.Models.Component", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<int>("ProductId");

                    b.Property<long?>("ProductId1");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("ProductId1");

                    b.ToTable("Component");
                });

            modelBuilder.Entity("VersionManagement.Models.ComponentType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ComponentType");
                });

            modelBuilder.Entity("VersionManagement.Models.Customer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("VersionManagement.Models.CustomerProduct", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("CustomerId");

                    b.Property<long?>("CustomerId1");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("LastVersionId");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("ProductId");

                    b.Property<long?>("ProductId1");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId1");

                    b.HasIndex("ProductId1");

                    b.ToTable("CustomerProduct");
                });

            modelBuilder.Entity("VersionManagement.Models.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("VersionManagement.Models.PublishActivity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("CustomerProductId");

                    b.Property<long?>("CustomerProductId1");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("VersionId");

                    b.Property<long?>("VersionId1");

                    b.HasKey("Id");

                    b.HasIndex("CustomerProductId1");

                    b.HasIndex("VersionId1");

                    b.ToTable("PublishActivity");
                });

            modelBuilder.Entity("VersionManagement.Models.Version", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment");

                    b.Property<int>("ComponentId");

                    b.Property<long?>("ComponentId1");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("ReleaseNumber");

                    b.HasKey("Id");

                    b.HasIndex("ComponentId1");

                    b.ToTable("Version");
                });

            modelBuilder.Entity("VersionManagement.Models.ChangeLog", b =>
                {
                    b.HasOne("VersionManagement.Models.ChangeLogType", "ChangeLogType")
                        .WithMany()
                        .HasForeignKey("ChangeLogTypeId");

                    b.HasOne("VersionManagement.Models.Version", "Version")
                        .WithMany()
                        .HasForeignKey("VersionId1");
                });

            modelBuilder.Entity("VersionManagement.Models.Component", b =>
                {
                    b.HasOne("VersionManagement.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId1");
                });

            modelBuilder.Entity("VersionManagement.Models.CustomerProduct", b =>
                {
                    b.HasOne("VersionManagement.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId1");

                    b.HasOne("VersionManagement.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId1");
                });

            modelBuilder.Entity("VersionManagement.Models.PublishActivity", b =>
                {
                    b.HasOne("VersionManagement.Models.CustomerProduct", "CustomerProduct")
                        .WithMany()
                        .HasForeignKey("CustomerProductId1");

                    b.HasOne("VersionManagement.Models.Version", "Version")
                        .WithMany()
                        .HasForeignKey("VersionId1");
                });

            modelBuilder.Entity("VersionManagement.Models.Version", b =>
                {
                    b.HasOne("VersionManagement.Models.Component", "Component")
                        .WithMany()
                        .HasForeignKey("ComponentId1");
                });
#pragma warning restore 612, 618
        }
    }
}