using FlFoxShop.Common.DBModels;
using FlFoxShop.Common.DBModels.TextileModels;
using FlFoxShop.Common.DBModels.UsersModels;
using FlFoxShop.DataBase.Configurations;

using Microsoft.EntityFrameworkCore;

namespace FlFoxShop.DataBase
{
    public class ShopDbContext : DbContext
    {

        public DbSet<User> Users => Set<User>();

        public DbSet<Textile> Textiles => Set<Textile>();

        public DbSet<TextileType> TextileTypes => Set<TextileType>();

        public DbSet<Brand> Brands => Set<Brand>();

        public DbSet<ProductPurpose> ProductPurposes => Set<ProductPurpose>();

        public ShopDbContext(DbContextOptions<ShopDbContext> options): base (options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new BrandConfiguration());
            modelBuilder.ApplyConfiguration(new ProductPurposeConfiguration());
            modelBuilder.ApplyConfiguration(new TextileConfiguration());
            modelBuilder.ApplyConfiguration(new TextileTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

        }


    }
}
