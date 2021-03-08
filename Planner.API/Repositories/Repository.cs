using Planner.API.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Planner.API.Repositories
{
    /// <summary>
    /// Implementation of the Repository pattern using TEntity.
    /// </summary>
    /// <typeparam name="TEntity">Entity type.</typeparam>
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        protected readonly PlannerDbContext PlannerDbContext;

        public Repository(PlannerDbContext plannerDbContext)
        {
            PlannerDbContext = plannerDbContext;
        }

        /// <summary>
        /// Get all TEntity.
        /// </summary>
        /// <returns>Queryable of TEntity.</returns>
        public IQueryable<TEntity> GetAll()
        {
            try
            {
                return PlannerDbContext.Set<TEntity>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Coulnd't retrieve entities: {ex.Message}");
            }
        }

        /// <summary>
        /// Get TEntity by id.
        /// </summary>
        /// <param name="id">Id of the entity.</param>
        /// <returns>The entity.</returns>
        public async Task<TEntity> GetAsync(long id)
        {
            try
            {
                return await PlannerDbContext.FindAsync<TEntity>(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entity with id: {id}, {ex.Message}");
            }
        }

        /// <summary>
        /// Add TEntity async.
        /// </summary>
        /// <param name="entity">Entity to add.</param>
        /// <returns>Added TEntity.</returns>
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                await PlannerDbContext.AddAsync(entity);
                await PlannerDbContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
            }
        }

        /// <summary>
        /// Update TEntity async.
        /// </summary>
        /// <param name="entity">Entity to update.</param>
        /// <returns>Updated TEntity.</returns>
        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                PlannerDbContext.Update(entity);
                await PlannerDbContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be updated: {ex.Message}");
            }
        }

        /// <summary>
        /// Delete TEntity async.
        /// </summary>
        /// <param name="entity">Entity to delete.</param>
        public async Task DeleteAsync(TEntity entity)
        {
            try
            {
                PlannerDbContext.Remove(entity);
                await PlannerDbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't delete entity: {ex.Message}");
            }
        }
    }
}
