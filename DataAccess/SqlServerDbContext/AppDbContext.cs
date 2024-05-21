using Entities.Concrete.TableModels;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DataAccess.SqlServerDbContext
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=Localhost;Database=TravelFinalProject4Db;Trusted_Connection=True;Encrypt=false;");
        }
        //Burda Xetan VAr yoxla sonra migration et!
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        //}

        public DbSet<About> Abouts { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Activitie> Activities { get; set; }
    }
}
