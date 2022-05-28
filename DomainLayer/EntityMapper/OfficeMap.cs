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
    public class OfficeMap : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnType("INT");
            builder.Property(e => e.OfficeName).HasColumnType("NVARCHAR(100)");
            builder.Property(e => e.Description).HasColumnType("NVARCHAR(MAX)");
        }
    }
}
