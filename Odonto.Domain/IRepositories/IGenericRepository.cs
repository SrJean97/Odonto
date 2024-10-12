namespace Odonto.Domain.IRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<bool> InsertAsync(T entity);
        //void Delete(T entity);
        //void Update(T entity);
        //Task<T> InsertAndReturnAsync(T entity);
        //Task<T> GetByIdAsync(object id, CancellationToken cancellationToken = default);
        //Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default);

    }
}
