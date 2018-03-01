
 

using Abp.Application.Services;
using Abp.Application.Services.Dto;
using zyGIS.TableConfigs.Dto;
using System;

namespace zyGIS.TableConfigs
{
    public interface ITableConfigService : IAsyncCrudAppService<TableConfigDto, Guid, PagedResultRequestDto, CreateTableConfigDto, TableConfigDto>
    {
		
    }
}