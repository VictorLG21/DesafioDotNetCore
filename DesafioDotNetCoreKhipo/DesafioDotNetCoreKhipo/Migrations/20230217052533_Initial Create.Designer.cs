﻿// <auto-generated />
using System;
using DesafioDotNetCoreKhipo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DesafioDotNetCoreKhipo.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230217052533_Initial Create")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DesafioDotNetCoreKhipo.Models.Products", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Brand = "Hauck - Johnson",
                            CreatedAt = new DateTime(2022, 5, 20, 0, 31, 8, 0, DateTimeKind.Unspecified),
                            Name = "Incredible Plastic Pants",
                            Price = 827m,
                            UpdatedAt = new DateTime(2022, 5, 22, 2, 31, 8, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 2,
                            Brand = "Johns - Farrell",
                            CreatedAt = new DateTime(2022, 5, 20, 9, 5, 23, 0, DateTimeKind.Unspecified),
                            Name = "Electronic Wooden Tuna",
                            Price = 765m,
                            UpdatedAt = new DateTime(2022, 5, 20, 9, 5, 23, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 3,
                            Brand = "Paucek, Kuvalis and Zieme",
                            CreatedAt = new DateTime(2022, 5, 20, 2, 7, 28, 0, DateTimeKind.Unspecified),
                            Name = "Awesome Steel Mouse",
                            Price = 143m,
                            UpdatedAt = new DateTime(2022, 5, 23, 22, 35, 23, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}