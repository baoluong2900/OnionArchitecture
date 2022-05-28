using DomainLayer.EntityMapper;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Department>().HasMany(e => e.Employees).WithOne(x => x.Department);
            modelBuilder.Entity<Office>().HasMany(e => e.Employees).WithOne(x => x.Office);
            modelBuilder.Entity<Title>().HasMany(e => e.Employees).WithOne(x => x.Title);

            modelBuilder.ApplyConfiguration(new EmployeeMap());
            modelBuilder.ApplyConfiguration(new DepartmentMap());
            modelBuilder.ApplyConfiguration(new OfficeMap());
            modelBuilder.ApplyConfiguration(new TitleMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
