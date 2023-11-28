using FlFoxShop.Common.DBModels.UsersModels;

namespace FlFoxShop.Common.DBModels
{
    /// <summary>
    /// Базовый класс для товаров
    /// </summary>
    public class Product
    {
        public long Id { get; set; }
        public required string Title { get; set; }

        public string? Description { get; set; }

        public string? SmallDescription { get; set; }

        public string? VendorCode { get; set; }
        public decimal? Price { get; set; }

        public long? BrendId { get; set; }

        public long? ProductPurposeId { get; set; }

        public ProductPurpose? ProductPurpose { get; set; }
        public Brand? Brand { get; set; }

        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public Guid UpdatedById { get; set; }
        public Guid CreateddById { get; set; }

        public User? UpdatedBy { get; set; }
        public User? CreateddBy { get; set; }
    }
}
