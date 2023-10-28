using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;

public interface IAstronomicalObjectRepository<TEntity> where TEntity : IAstronomicalObject
{
    Task<TEntity?> GetByIdAsync(string id);
    Task<TEntity?> GetByIdWithChildrenAsync(string id);
    Task<List<TEntity>> GetAllAsync();
    Task AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
}