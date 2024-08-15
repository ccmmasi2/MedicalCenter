using MedicalCenter.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalCenter.Core.Configuration
{
    public class IdentificationTypeConfiguration : IEntityTypeConfiguration<IdentificationTypeDTO>
    {
        public void Configure(EntityTypeBuilder<IdentificationTypeDTO> builder)
        {
            builder.Property(c => c.ID).IsRequired();
            builder.Property(c => c.Name).IsRequired();
        }
    }
}
