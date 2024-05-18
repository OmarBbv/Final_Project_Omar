using Entities.Entities.Concrete.TableModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class TestimonialConfiguration : IEntityTypeConfiguration<Testimonial>
    {
        public void Configure(EntityTypeBuilder<Testimonial> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.FeedBack).IsRequired().HasMaxLength(3000);
            builder.Property(x => x.Location).IsRequired().HasMaxLength(100);
            builder.Property(x => x.PhotoUrl).IsRequired().HasMaxLength(350);
            
            builder.HasIndex(x => new { x.Id, x.Deleted }).IsUnique();
        }
    }
}
