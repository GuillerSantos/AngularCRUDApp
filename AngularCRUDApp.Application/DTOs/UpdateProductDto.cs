namespace AngularCRUDApp.Application.DTOs
{
    public class UpdateProductDto
    {
        #region Properties

        public Guid Id { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string ProductDescription { get; set; } = string.Empty;
        public decimal ProductPrice { get; set; }
        public int ProductStock { get; set; }
        public string ProductImage { get; set; } = string.Empty;
        public string ProductCategory { get; set; } = string.Empty;
        public string ProductBrand { get; set; } = string.Empty;

        #endregion Properties
    }
}