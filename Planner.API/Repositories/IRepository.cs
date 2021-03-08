using System.Linq;
using System.Threading.Tasks;

namespace Planner.API.Repositories
{
    /// <summary>
    /// Interface defining a repository.
    /// </summary>
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        /// <summary>
        /// Get all TEntity.
        /// </summary>
        /// <returns>Queryable of TEntity.</returns>
        IQueryable<TEntity> GetAll();

        /// <summary>
        /// Get TEntity by id async.
        /// </summary>
        /// <param name="id">Id of the entity.</param>
        /// <returns>The entity.</returns>
        Task<TEntity> GetAsync(long id);

        /// <summary>
        /// Add TEntity async.
        /// </summary>
        /// <param name="entity">Entity to add.</param>
        /// <returns>Added TEntity.</returns>
        Task<TEntity> AddAsync(TEntity entity);

        /// <summary>
        /// Update TEntity async.
        /// </summary>
        /// <param name="entity">Entity to update.</param>
        /// <returns>Updated TEntity.</returns>
        Task<TEntity> UpdateAsync(TEntity entity);

        /// <summary>
        /// Delete TEntity async.
        /// </summary>
        /// <param name="entity">Entity to delete.</param>
        Task DeleteAsync(TEntity entity);
    }
}
