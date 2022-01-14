using Example.Blog.Domain.Interfaces.Models.Base;

namespace Example.Blog.Domain.Interfaces.Models
{
    /// <summary>
    /// Represent a tenant
    /// </summary>
    public interface ITenant : IEntityBase, IEntityChanges, IEntitySoftDelete
    {
        /// <summary>
        /// Name of the Tenant
        /// </summary>
        string Name { get; set; }
    }
}
