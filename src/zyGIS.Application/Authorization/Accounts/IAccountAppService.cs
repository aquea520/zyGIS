using System.Threading.Tasks;
using Abp.Application.Services;
using zyGIS.Authorization.Accounts.Dto;

namespace zyGIS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
