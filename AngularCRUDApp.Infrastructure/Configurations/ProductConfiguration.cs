using AngularCRUDApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AngularCRUDApp.Infrastructure.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Products>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasKey(p => p.Id);
        }

        #endregion Public Methods
    }
}