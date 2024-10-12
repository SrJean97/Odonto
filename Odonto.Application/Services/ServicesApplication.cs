using AutoMapper;
using Odonto.Application.Commons.Bases.Response;
using Odonto.Application.ServiceAbstraction;
using Odonto.Domain.IRepositories;
using Odonto.Shared.DTOs.ServicesDTO;

namespace Odonto.Application.Services
{
    public class ServicesApplication : IServicesApplication
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public ServicesApplication(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }


        public async Task<BaseResponse<bool>> CreateService(ServiceRequestDto requestDto)
        {
            var response = new BaseResponse<bool>();

            var service = _mapper.Map<Odonto.Domain.Entities.Services>(requestDto);
            service.Status = true;
            response.Data = await _repositoryManager.Services.InsertAsync(service);

            if (response.Data)
            {
                response.IsSuccess = true;
                response.Message = "Guardado exitosamente";
            }
            else
            {
                response.IsSuccess = false;
                response.Message = "Error al intentar guardar.";
            }

            return response;
        }
    }
}
