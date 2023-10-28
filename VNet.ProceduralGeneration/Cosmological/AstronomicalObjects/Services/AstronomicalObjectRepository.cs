using Microsoft.EntityFrameworkCore;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services
{
    public class AstronomicalObjectRepository<TEntity> : IAstronomicalObjectRepository<TEntity> where TEntity : AstronomicalObject
    {
        private readonly DbContext _dbContext;

        public AstronomicalObjectRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TEntity?> GetByIdAsync(string id)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id) ?? null;
        }

        public async Task<TEntity?> GetByIdWithChildrenAsync(string id)
        {
            var query = _dbContext.Set<TEntity>().Where(e => e.Id == id);
            var navigationProperties = _dbContext.Model.FindEntityType(typeof(TEntity))?.GetNavigations();

            if (navigationProperties != null) query = navigationProperties.Aggregate(query, (current, property) => current.Include(property.Name));

            var entityWithChildren = await query.FirstOrDefaultAsync();

            return entityWithChildren;
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _dbContext.Set<TEntity>().ToListAsync();
        }

        public async Task AddAsync(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}