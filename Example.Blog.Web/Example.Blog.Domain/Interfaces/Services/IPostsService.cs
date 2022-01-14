using Example.Blog.Domain.Interfaces.Models;
using Example.Blog.Domain.ModelsHelpers;
using System.Collections.Generic;
using System.Threading;

namespace Example.Blog.Domain.Interfaces.Services
{
    /// <summary>
    /// Represent application entity (internal or external)
    /// </summary>
    public interface IPostsService
    {
        /// <summary>
        /// Count all items
        /// </summary>
        /// <param name="itemParamsHelper">Sorting and filters</param>
        /// <param name="cancelToken">cancel token</param>
        /// <returns>Count of elements</returns>
        long GetCountAll(PostParamsHelper itemParamsHelper, CancellationToken cancelToken = default);

        /// <summary>
        /// Retrieve items
        /// </summary>
        /// <param name="itemParamsHelper">Sorting and filters</param>
        /// <param name="cancelToken">cancel token</param>
        /// <returns>List of items</returns>
        IEnumerable<IPost> GetAll(PostParamsHelper itemParamsHelper, CancellationToken cancelToken = default);

        /// <summary>
        /// Retrieve an item from identifier
        /// </summary>
        /// <param name="id">identifier of the item</param>
        /// <param name="cancelToken">cancel token</param>
        /// <returns>the item with id</returns>
        IPost GetById(int id, CancellationToken cancelToken = default);

        /// <summary>
        /// Insert a new item
        /// </summary>
        /// <param name="item">data of the new item</param>
        /// <param name="useRegistryEvents">use registry events or not</param>
        /// <param name="cancelToken">cancel token</param>
        void Insert(IPost item, bool useRegistryEvents = true, CancellationToken cancelToken = default);

        /// <summary>
        /// Update an item by id
        /// </summary>
        /// <param name="id">id of the item</param>
        /// <param name="item">data of the new post</param>
        /// <param name="useRegistryEvents">use registry events or not</param>
        /// <param name="cancelToken">cancel token</param>
        void UpdateById(long id, IPost item, bool useRegistryEvents = true, CancellationToken cancelToken = default);

        /// <summary>
        /// Delete an item
        /// </summary>
        /// <param name="item">the item to delete</param>
        /// <param name="useRegistryEvents">use registry events or not</param>
        /// <param name="cancelToken">cancel token</param>
        void Delete(IPost item, bool useRegistryEvents = true, CancellationToken cancelToken = default);

        /// <summary>
        /// Delete an item by id
        /// </summary>
        /// <param name="id">id of the item</param>
        /// <param name="useRegistryEvents">use registry events or not</param>
        /// <param name="cancelToken">cancel token</param>
        void DeleteById(long id, bool useRegistryEvents = true, CancellationToken cancelToken = default);
    }
}