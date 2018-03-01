
 

using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using zyGIS.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using Abp.Authorization;
using Microsoft.EntityFrameworkCore;
using Abp.IdentityFramework;
using zyGIS.Peoples.Dto;
using System;
using System.Collections.Generic;
using Abp.Linq.Extensions;

namespace zyGIS.Peoples
{
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class PeopleService : zyGISAsyncCrudAppService<People, PeopleDto, Guid, PagedResultRequestDto, CreatePeopleDto, PeopleDto>, IPeopleService
    {
        public PeopleService(IRepository<People, Guid> repository): base(repository)
        {
            
        }

    }
}