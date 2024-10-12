using Odonto.Domain.Entities;
using Odonto.Domain.IRepositories;
using Odonto.Infrastructure.Persistence.Context;

namespace Odonto.Infrastructure.Repositories
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly OdontoContext _context;
        private readonly Lazy<IUnitOfWork> _lazyUnitOfWork;
        private readonly Lazy<IGenericRepository<Services>> _lazyServcies;
        //private readonly Dictionary<Type, object> _repositories;

        public RepositoryManager(OdontoContext context)
        {
            _context = context;
            _lazyUnitOfWork = new Lazy<IUnitOfWork>(() => new UnitOfWork(_context));
            _lazyServcies = new Lazy<IGenericRepository<Services>>(() => new GenericRepository<Services>(_context));
            //_repositories = new Dictionary<Type, object>();
        }

        public IUnitOfWork UnitOfWork => _lazyUnitOfWork.Value;
        public IGenericRepository<Services> Services => _lazyServcies.Value;


        //public IGenericRepository<T> GenericRepository<T>() where T : class
        //{
        //    if (_repositories.TryGetValue(typeof(T), out var repository))
        //    {
        //        return (IGenericRepository<T>)repository;
        //    }

        //    var newLazyRepository = new GenericRepository<T>(_context);
        //    _repositories[typeof(T)] = newLazyRepository;

        //    return newLazyRepository;
        //}
    }
}
