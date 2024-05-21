using Entities.Concrete.TableModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations
{
    public class AboutConfiguration : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
            builder.Property(x => x.Description).IsRequired().HasMaxLength(3000);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(2000);
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => new { x.Id, x.Deleted }).IsUnique();
        }
    }
}
