using Abp.Application.Services;
using Abp.Application.Services.Dto;
using zyGIS.MultiTenancy.Dto;

namespace zyGIS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
