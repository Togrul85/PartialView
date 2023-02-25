using FirelloProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FirelloProject.DAL
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions options):base(options)
        {
                
        }
        public DbSet<Slider>? Slider { get; set; }
        public DbSet<SliderDetail>? SliderDetails { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<ProductImage>? ProductImages { get; set; }

    }
}
