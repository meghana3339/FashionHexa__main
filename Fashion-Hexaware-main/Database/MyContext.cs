using FashionHexa.Entities;
using Microsoft.EntityFrameworkCore;


namespace FashionHexa.Database
{
    public class MyContext : DbContext
    {
        private IConfiguration config;
        public MyContext(IConfiguration cfg) 
        {
            config = cfg;
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        //public DbSet<Role> Roles { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Availability> Availabilities { get; set; }
        public DbSet<UserRatings> UserRatings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-DH150A5\\MSSQLSERVER01; Initial Catalog =projDb; User Id = meghana; Password = meghana3339; TrustServerCertificate = true");
            base.OnConfiguring(optionsBuilder);
        }


    }
}
