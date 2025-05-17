namespace AngularCRUDApp.Domain.Abstractions
{
    public abstract class BaseAuditableEntity : BaseEntity
    {
        #region Properties

        public DateTimeOffset Created { get; set; }
        public string? CreatedBy { get; set; }
        public DateTimeOffset? LastModified { get; set; }
        public string? LastModifiedBy { get; set; }

        #endregion Properties
    }
}