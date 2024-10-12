using Microsoft.EntityFrameworkCore;
using Odonto.Domain.IRepositories;
using Odonto.Infrastructure.Persistence.Context;

namespace Odonto.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly OdontoContext _odontoContext;
        protected readonly DbSet<T> _dbset;

        public GenericRepository(OdontoContext context)
        {
            _odontoContext = context;
            _dbset = _odontoContext.Set<T>();
        }

        public async Task<bool> InsertAsync(T entity)
        {
            await _dbset.AddAsync(entity);
            var recordAffected = await _odontoContext.SaveChangesAsync();
            return recordAffected > 0;
        }
    }
}
