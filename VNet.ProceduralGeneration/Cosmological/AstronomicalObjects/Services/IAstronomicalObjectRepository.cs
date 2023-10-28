using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;

public interface IAstronomicalObjectRepository<TEntity> where TEntity : IAstronomicalObject
{
    Task<TEntity?> GetByIdAsync(int id);
    Task<List<TEntity>> GetByIdWithChildrenAsync(int id);
    Task<List<TEntity>> GetAllAsync();
    Task AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
}