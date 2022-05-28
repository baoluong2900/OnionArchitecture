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
    public class TitleMap : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnType("INT");
            builder.Property(e => e.TitleName).HasColumnType("NVARCHAR(100)");
            builder.Property(e => e.Description).HasColumnType("NVARCHAR(MAX)");
        }
    }
}
