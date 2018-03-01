using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using zyGIS.Roles.Dto;
using zyGIS.Users.Dto;
using zyGIS.Form.Dto;
using System;

namespace zyGIS.Form
{
    public interface IFormAppService : IAsyncCrudAppService<FormDto, Guid, PagedResultRequestDto, CreateFormDto, FormDto>
    {

    }
}