namespace Odonto.Domain.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        Task BeginTransaction();
        Task Commit();
        Task RollBack();
        Task SaveChangesAsync();
        void SaveChanges();
    }
}
