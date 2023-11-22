using FlFoxShop.Common.DBModels.TextileModels;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlFoxShop.DataBase.Configurations
{
    public class TextileTypeConfiguration : IEntityTypeConfiguration<TextileType>
    {
        public void Configure(EntityTypeBuilder<TextileType> builder)
        {
            builder.ToTable("shop_Textile_Types");

            builder.Property(p => p.Title).HasMaxLength(255);
        }
    }
}
