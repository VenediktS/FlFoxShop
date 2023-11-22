using FlFoxShop.Common.DBModels;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlFoxShop.DataBase.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("shop_Brands");

            builder.Property(p => p.Title).HasMaxLength(255);
        }
    }
}
