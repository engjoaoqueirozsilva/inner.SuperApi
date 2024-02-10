using System.Threading.Tasks;
using Abp.Application.Services;
using inner.masterApi.Sessions.Dto;

namespace inner.masterApi.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
