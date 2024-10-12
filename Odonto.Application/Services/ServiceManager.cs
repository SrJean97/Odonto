using AutoMapper;
using Odonto.Application.ServiceAbstraction;
using Odonto.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odonto.Application.Services
{
    public sealed class ServiceManager : IServiceManager
    {

        private readonly Lazy<IServicesApplication> _lazyServiceApplication;

        public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _lazyServiceApplication = new Lazy<IServicesApplication>(() => new ServicesApplication(repositoryManager, mapper));
        }
        public IServicesApplication ServicesApplication => _lazyServiceApplication.Value;
    }
}
