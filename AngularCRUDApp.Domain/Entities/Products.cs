using AngularCRUDApp.Domain.Abstractions;

namespace AngularCRUDApp.Domain.Entities
{
    public class Products : BaseEntity
    {
        #region Properties

        public string ProductName { get; set; } = string.Empty;

        public string ProductDescription { get; set; } = string.Empty;

        public DateTime? CreatedAt { get; set; }

        public decimal ProductPrice { get; set; }

        public int ProductStock { get; set; }

        public string ProductImage { get; set; } = string.Empty;

        public string ProductCategory { get; set; } = string.Empty;

        public string ProductBrand { get; set; } = string.Empty;

        #endregion Properties
    }
}