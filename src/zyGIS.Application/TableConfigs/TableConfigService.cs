
 

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
using zyGIS.TableConfigs.Dto;
using System;
using System.Collections.Generic;

namespace zyGIS.TableConfigs
{
    public class TableConfigService : AsyncCrudAppService<TableConfig, TableConfigDto, Guid, PagedResultRequestDto, CreateTableConfigDto, TableConfigDto>, ITableConfigService
    {
        public TableConfigService(IRepository<TableConfig, Guid> repository): base(repository)
        {
            
        }

		
	}
}