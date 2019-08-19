using System.Threading.Tasks;
using Abp.Application.Services;
using ABPDocker.Sessions.Dto;

namespace ABPDocker.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
