using Odonto.Domain.IRepositories;
using Odonto.Infrastructure.Persistence.Context;

namespace Odonto.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly OdontoContext _odontoContext;

        public UnitOfWork(OdontoContext odontoContext)
        {
            _odontoContext = odontoContext;
        }

        public IGenericRepository<T> GenericRepository<T>() where T : class
        {
            return new GenericRepository<T>(_odontoContext);
        }

        public async Task BeginTransaction()
        {
            await _odontoContext.Database.BeginTransactionAsync();
        }

        public async Task Commit()
        {
            try
            {
                _odontoContext.SaveChanges();
                await _odontoContext.Database.CommitTransactionAsync();
            }
            catch { }
        }

        public void Dispose()
        {
            _odontoContext?.Dispose();
        }

        public async Task RollBack()
        {
            await _odontoContext.Database.RollbackTransactionAsync();
        }

        public void SaveChanges()
        {
            _odontoContext.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _odontoContext.SaveChangesAsync();
        }
    }
}
