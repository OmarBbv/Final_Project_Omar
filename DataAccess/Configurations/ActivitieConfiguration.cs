using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete.TableModels;

namespace DataAccess.Configurations
{
    public class ActivitieConfiguration : IEntityTypeConfiguration<Activitie>
    {
        public void Configure(EntityTypeBuilder<Activitie> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Text).IsRequired().HasMaxLength(500);
            builder.HasIndex(x => new { x.Id, x.Deleted }).IsUnique();
            builder.HasOne(x => x.About).WithMany(x => x.Activitie).HasForeignKey(x=> x.AboutId);
        }
    }
}
