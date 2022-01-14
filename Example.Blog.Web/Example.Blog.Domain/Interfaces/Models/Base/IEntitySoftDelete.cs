using System;

namespace Example.Blog.Domain.Interfaces.Models.Base
{
    /// <summary>
    /// Entity properties for registry deleted data
    /// </summary>
    public interface IEntitySoftDelete
    {
        /// <summary>
        /// Internal identifier
        /// </summary>
        long? DeletedId { get; set; }

        /// <summary>
        /// Deleted date
        /// </summary>
        DateTime? DeletedDate { get; set; }
    }
}
