using Core.Entity;
using Core.Utilities.Results;

namespace AccountManager.Business.Abstract
{
    public interface IAsyncBaseService<TDto, TEntity>
        where TDto : class, IDto, new()
        where TEntity : class, IEntity, new()
    {
        Task<IResult> AddAsync(TEntity entity);
        Task<IResult> UpdateAsync(TEntity entity);
        Task<IResult> DeleteAsync(TEntity entity);

        Task<IDataResult<TEntity>> GetByIdAsync(int id);
        Task<IDataResult<IEnumerable<TEntity>>> GetAllAsync();
    }
}
