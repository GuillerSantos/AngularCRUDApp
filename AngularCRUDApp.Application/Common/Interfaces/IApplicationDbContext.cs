using AngularCRUDApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AngularCRUDApp.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        #region Properties

        DbSet<Products> Products { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        #endregion Properties
    }
}