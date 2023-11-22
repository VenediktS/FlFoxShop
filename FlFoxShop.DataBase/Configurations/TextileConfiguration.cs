using FlFoxShop.Common.DBModels.TextileModels;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlFoxShop.DataBase.Configurations
{
    public class TextileConfiguration: IEntityTypeConfiguration<Textile>
    {
        public void Configure(EntityTypeBuilder<Textile> builder) 
        {
            builder.ToTable("shop_Textiles");

            builder.Property(p => p.Color).HasMaxLength(255);
            builder.Property(p => p.Title).HasMaxLength(255);
            builder.Property(p => p.SmallDescription).HasMaxLength(255);
            builder.Property(p => p.DrawingTextDescription).HasMaxLength(255);
            builder.Property(p => p.TextileBase).HasMaxLength(255);

            builder.Property(p => p.Description).HasMaxLength(2000);
        }
    }
}
