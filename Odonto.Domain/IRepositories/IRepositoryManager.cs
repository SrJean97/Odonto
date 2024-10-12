using Odonto.Domain.Entities;

namespace Odonto.Domain.IRepositories
{
    public interface IRepositoryManager
    {
        //IGenericRepository<T> GenericRepository<T>() where T : class;
        IGenericRepository<Services> Services {  get; }
        IUnitOfWork UnitOfWork { get; }
    }
}
