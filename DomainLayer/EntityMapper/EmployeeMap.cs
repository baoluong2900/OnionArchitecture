using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.EntityMapper
{
    public class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnType("INT");
            builder.Property(e => e.DepartmentId).HasColumnType("INT");
            builder.Property(e => e.OfficeId).HasColumnType("INT");
            builder.Property(e => e.TitleId).HasColumnType("INT");
            builder.Property(e => e.BirthDate).HasColumnType("DATETIME");
            builder.Property(e => e.FirstName).HasColumnType("NVARCHAR(100)");
            builder.Property(e => e.LastName).HasColumnType("NVARCHAR(100)");
            builder.Property(e => e.Sex).HasColumnType("NVARCHAR(10)");
            builder.Property(e => e.Avatar).HasColumnType("NVARCHAR(255)");
            builder.Property(e => e.CreateDate).HasColumnType("DATETIME");
            builder.Property(e => e.Active).HasColumnType("BIT");
       
        }
    }
}
