using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using zyGIS.Roles.Dto;
using zyGIS.Users.Dto;

namespace zyGIS.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
