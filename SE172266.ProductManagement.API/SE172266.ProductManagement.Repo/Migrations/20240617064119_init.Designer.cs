﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SE172266.ProductManagement.Repo.Entities;

#nullable disable

namespace SE172266.ProductManagement.Repo.Migrations
{
    [DbContext(typeof(MyStoreDBContext))]
    [Migration("20240617064119_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SE172266.ProductManagement.Repo.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Beverages",
                            IsDeleted = false
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Condiments",
                            IsDeleted = false
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Confections",
                            IsDeleted = false
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Dairy Products",
                            IsDeleted = false
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Grains/Cereals",
                            IsDeleted = false
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Meat/Poultry",
                            IsDeleted = false
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Produce",
                            IsDeleted = false
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "Seafood",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("SE172266.ProductManagement.Repo.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UnitsInStock")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            IsDeleted = false,
                            ProductName = "Pizza",
                            UnitPrice = 5m,
                            UnitsInStock = 1
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 2,
                            IsDeleted = false,
                            ProductName = "Hamburger",
                            UnitPrice = 6m,
                            UnitsInStock = 2
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 3,
                            IsDeleted = false,
                            ProductName = "Sushi",
                            UnitPrice = 7m,
                            UnitsInStock = 3
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 5,
                            IsDeleted = false,
                            ProductName = "Fried Chicken",
                            UnitPrice = 8m,
                            UnitsInStock = 5
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 6,
                            IsDeleted = false,
                            ProductName = "Salmon",
                            UnitPrice = 8m,
                            UnitsInStock = 6
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 7,
                            IsDeleted = false,
                            ProductName = "Steak",
                            UnitPrice = 9m,
                            UnitsInStock = 7
                        });
                });

            modelBuilder.Entity("SE172266.ProductManagement.Repo.Entities.Product", b =>
                {
                    b.HasOne("SE172266.ProductManagement.Repo.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("SE172266.ProductManagement.Repo.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
