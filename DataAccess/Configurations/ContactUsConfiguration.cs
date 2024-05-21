using Entities.Concrete.TableModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class ContactUsConfiguration : IEntityTypeConfiguration<ContactUs>
    {
        public void Configure(EntityTypeBuilder<ContactUs> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(13);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(3000);
            builder.Property(x => x.Location).IsRequired().HasMaxLength(55);
            builder.HasIndex(x => new { x.Id, x.Deleted }).IsUnique();

        }
    }
}
