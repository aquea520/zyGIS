using System.Threading.Tasks;
using Abp.Application.Services;
using zyGIS.Sessions.Dto;

namespace zyGIS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
