using MedicalCenter.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalCenter.Core.Configuration
{
    public class CityConfiguration : IEntityTypeConfiguration<CityDTO>
    {
        public void Configure(EntityTypeBuilder<CityDTO> builder)
        {
            builder.Property(c => c.ID).IsRequired();
            builder.Property(c => c.Name).IsRequired();

            builder.HasOne(e => e.Department).WithMany().HasForeignKey(e => e.DepartmentId);
        }
    }
}
