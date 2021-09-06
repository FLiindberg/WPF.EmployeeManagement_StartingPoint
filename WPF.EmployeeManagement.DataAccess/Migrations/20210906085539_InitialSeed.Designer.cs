﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WPF.EmployeeManagement.DataAccess;

namespace WPF.EmployeeManagement.DataAccess.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    [Migration("20210906085539_InitialSeed")]
    partial class InitialSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WPF.EmployeeManagement.UI.Model.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Department")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Department = 1,
                            Email = "johnny@gmail.com",
                            Firstname = "Rafael",
                            Lastname = "Milanes"
                        },
                        new
                        {
                            Id = 2,
                            Department = 1,
                            Email = "Juan@gmail.com",
                            Firstname = "Johnny",
                            Lastname = "Cage"
                        },
                        new
                        {
                            Id = 3,
                            Department = 2,
                            Email = "Anna@gmail.com",
                            Firstname = "Anna",
                            Lastname = "Lindgren"
                        },
                        new
                        {
                            Id = 4,
                            Department = 3,
                            Email = "John@gmail.com",
                            Firstname = "Juanete",
                            Lastname = "Pérez"
                        },
                        new
                        {
                            Id = 5,
                            Department = 3,
                            Email = "new@gmail.com",
                            Firstname = "New",
                            Lastname = "SuperNew"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
