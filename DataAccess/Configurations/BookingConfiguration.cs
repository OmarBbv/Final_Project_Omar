using Entities.Concrete.TableModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IconUrl).IsRequired().HasMaxLength(350);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(3000);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(2000);
            builder.HasIndex(x => new { x.Id, x.Deleted }).IsUnique();

        }
    }
}
