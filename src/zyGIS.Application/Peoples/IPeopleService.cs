
 

using Abp.Application.Services;
using Abp.Application.Services.Dto;
using zyGIS.Peoples.Dto;
using System;

namespace zyGIS.Peoples
{
    public interface IPeopleService : IAsyncCrudAppService<PeopleDto, Guid, PagedResultRequestDto, CreatePeopleDto, PeopleDto>
    {
		
    }
}