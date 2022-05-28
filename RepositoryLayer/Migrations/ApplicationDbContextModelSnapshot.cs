﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositoryLayer;

namespace RepositoryLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DomainLayer.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit")
                        .HasColumnName("Active");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreateDate");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("DepartmentName");

                    b.Property<string>("Description")
                        .HasColumnType("NVARCHAR(MAX)")
                        .HasColumnName("Description");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("DomainLayer.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("BIT")
                        .HasColumnName("Active");

                    b.Property<string>("Avatar")
                        .HasColumnType("NVARCHAR(255)")
                        .HasColumnName("Avatar");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("DATETIME")
                        .HasColumnName("BirhDate");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("DATETIME")
                        .HasColumnName("CreateDate");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("INT")
                        .HasColumnName("DepartmentID");

                    b.Property<string>("FirstName")
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("LastName");

                    b.Property<int>("OfficeId")
                        .HasColumnType("INT")
                        .HasColumnName("OfficeID");

                    b.Property<string>("Sex")
                        .HasColumnType("NVARCHAR(10)")
                        .HasColumnName("Sex");

                    b.Property<int>("TitleId")
                        .HasColumnType("INT")
                        .HasColumnName("TitleID");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("OfficeId");

                    b.HasIndex("TitleId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("DomainLayer.Models.Office", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit")
                        .HasColumnName("Active");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreateDate");

                    b.Property<string>("Description")
                        .HasColumnType("NVARCHAR(MAX)")
                        .HasColumnName("Description");

                    b.Property<string>("OfficeName")
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("OfficeName");

                    b.HasKey("Id");

                    b.ToTable("Offices");
                });

            modelBuilder.Entity("DomainLayer.Models.Title", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit")
                        .HasColumnName("Active");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreateDate");

                    b.Property<string>("Description")
                        .HasColumnType("NVARCHAR(MAX)")
                        .HasColumnName("Description");

                    b.Property<string>("TitleName")
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("TitleName");

                    b.HasKey("Id");

                    b.ToTable("Titles");
                });

            modelBuilder.Entity("DomainLayer.Models.Employee", b =>
                {
                    b.HasOne("DomainLayer.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DomainLayer.Models.Office", "Office")
                        .WithMany("Employees")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DomainLayer.Models.Title", "Title")
                        .WithMany("Employees")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Office");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("DomainLayer.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("DomainLayer.Models.Office", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("DomainLayer.Models.Title", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
