using ApıProjeKampi.WebApi.Entities;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;

namespace ApıProjeKampi.WebApi.Context
{
    public class ApiContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            optionsBuilder.UseSqlServer("Server=SAP93-01;Initial Catalog=ApiYummyDb;User ID=sa;Password=KD93p.dQmke!;");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Chef> Chefs  { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }

    }
}
 