using Entities.Concrete.TableModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TwitterLink).IsRequired().HasMaxLength(400);
            builder.Property(x => x.FaceBookLink).IsRequired().HasMaxLength(400);
            builder.Property(x => x.LinkednLink).IsRequired().HasMaxLength(400);
            builder.Property(x => x.SurName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Position).IsRequired().HasMaxLength(200);
            builder.Property(x => x.PhotoUrl).IsRequired().HasMaxLength(350);
            builder.HasIndex(x => new { x.Id, x.Deleted }).IsUnique();
        }
    }
}
