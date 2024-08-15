using MedicalCenter.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalCenter.Core.Configuration
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<DepartmentDTO>
    {
        public void Configure(EntityTypeBuilder<DepartmentDTO> builder)
        {
            builder.Property(c => c.ID).IsRequired();
            builder.Property(c => c.Name).IsRequired();

            builder.HasOne(e => e.Country).WithMany().HasForeignKey(e => e.CountryId);
        }
    }
}
