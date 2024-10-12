using Odonto.Application.Commons.Bases.Response;
using Odonto.Shared.DTOs.ServicesDTO;

namespace Odonto.Application.ServiceAbstraction
{
    public interface IServicesApplication
    {
        Task<BaseResponse<bool>> CreateService(ServiceRequestDto requestDto);
    }
}
