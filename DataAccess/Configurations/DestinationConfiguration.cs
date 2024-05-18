using Entities.Entities.Concrete.TableModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class DestinationConfiguration : IEntityTypeConfiguration<Destination>
    {
        public void Configure(EntityTypeBuilder<Destination> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PhotoUrl).IsRequired().HasMaxLength(350);
            builder.HasIndex(x => new { x.Id, x.Deleted }).IsUnique();
        }
    }
}
