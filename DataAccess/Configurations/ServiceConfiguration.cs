using Entities.Concrete.TableModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(55);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(3000);
            builder.Property(x => x.Icon).IsRequired().HasMaxLength(350);
            builder.HasIndex(x => new { x.Id, x.Deleted }).IsUnique();
        }
    }
}
