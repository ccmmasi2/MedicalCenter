using MedicalCenter.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalCenter.Core.Configuration
{
    public class CountryConfiguration : IEntityTypeConfiguration<CountryDTO>
    {
        public void Configure(EntityTypeBuilder<CountryDTO> builder)
        {
            builder.Property(c => c.ID).IsRequired();
            builder.Property(c => c.Name).IsRequired();
        }
    }
}
