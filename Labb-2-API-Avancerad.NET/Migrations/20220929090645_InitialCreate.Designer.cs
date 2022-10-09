﻿// <auto-generated />
using System;
using Labb_2_API_Avancerad.NET.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Labb_2_API_Avancerad.NET.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    [Migration("20220929090645_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Labb_2_API_Avancerad.NET.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            Name = "IT"
                        },
                        new
                        {
                            DepartmentId = 2,
                            Name = "HR"
                        },
                        new
                        {
                            DepartmentId = 3,
                            Name = "Economy"
                        },
                        new
                        {
                            DepartmentId = 4,
                            Name = "Service"
                        });
                });

            modelBuilder.Entity("Labb_2_API_Avancerad.NET.Models.Employee", b =>
                {
                    b.Property<Guid>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("GenderId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = new Guid("ec3444ba-a54c-418f-8db6-dd29f3b99747"),
                            Adress = "Hertings Allé 5A",
                            City = "Falkenberg",
                            DepartmentId = 1,
                            Email = "narfgren@hotmail.com",
                            FirstName = "Lucas",
                            GenderId = 1,
                            LastName = "Narfgren",
                            Phone = "0707409223",
                            Salary = 50000m,
                            ZipCode = "311 45"
                        });
                });

            modelBuilder.Entity("Labb_2_API_Avancerad.NET.Models.Gender", b =>
                {
                    b.Property<int>("GenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenderId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenderId");

                    b.ToTable("Genders");

                    b.HasData(
                        new
                        {
                            GenderId = 1,
                            Name = "Male"
                        },
                        new
                        {
                            GenderId = 2,
                            Name = "Female"
                        },
                        new
                        {
                            GenderId = 3,
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("Labb_2_API_Avancerad.NET.Models.Employee", b =>
                {
                    b.HasOne("Labb_2_API_Avancerad.NET.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb_2_API_Avancerad.NET.Models.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Gender");
                });
#pragma warning restore 612, 618
        }
    }
}
