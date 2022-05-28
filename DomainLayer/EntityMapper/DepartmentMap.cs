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
    public class DepartmentMap : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnType("INT");
            builder.Property(e => e.DepartmentName).HasColumnType("NVARCHAR(100)");
            builder.Property(e => e.Description).HasColumnType("NVARCHAR(MAX)");
        }
    }
}
