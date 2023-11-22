using FlFoxShop.Common.DBModels;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace FlFoxShop.DataBase.Configurations
{
    public class ProductPurposeConfiguration : IEntityTypeConfiguration<ProductPurpose>
    {
        public void Configure(EntityTypeBuilder<ProductPurpose> builder)
        {
            builder.ToTable("shop_Product_Purposes");

            builder.Property(p => p.Title).HasMaxLength(255);
        }
    }
}
