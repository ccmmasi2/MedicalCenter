using MedicalCenter.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalCenter.Core.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<CustomerDTO>
    {
        public void Configure(EntityTypeBuilder<CustomerDTO> builder)
        {
            builder.Property(c => c.ID).IsRequired();
            builder.Property(c => c.Identification).IsRequired();
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.LastName).IsRequired();
            builder.Property(c => c.BirthDay).IsRequired();
            builder.Property(c => c.IdentificationTypeId).IsRequired();
            builder.Property(c => c.CityId).IsRequired();
            builder.Property(c => c.Active).IsRequired();

            builder.HasOne(e => e.IdentificationType).WithMany().HasForeignKey(e => e.IdentificationTypeId);
            builder.HasOne(e => e.City).WithMany().HasForeignKey(e => e.CityId);
        }
    }
}
