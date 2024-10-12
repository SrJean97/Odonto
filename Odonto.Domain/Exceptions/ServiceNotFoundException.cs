namespace Odonto.Domain.Exceptions
{
    public sealed class ServiceNotFoundException : NotFoundException
    {
        public ServiceNotFoundException(int id)
            : base($"The service with the identifier { id } was not found.")
        { }
    }
}
