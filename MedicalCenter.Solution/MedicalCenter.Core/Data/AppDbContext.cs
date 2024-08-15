using MedicalCenter.Core.Models;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace MedicalCenter.Core.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<CityDTO> Cities { get; set; }
        public DbSet<CountryDTO> Countries { get; set; }
        public DbSet<CustomerDTO> Customers { get; set; }
        public DbSet<DepartmentDTO> Departments { get; set; }
        public DbSet<IdentificationTypeDTO> IdentificationTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

