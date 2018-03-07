using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Stbis.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace zyGIS
{
    public abstract class zyGISAsyncCrudAppService<TEntity, TEntityDto, TPrimaryKey, TGetAllInput, TCreateInput, TUpdateInput> 
        : AsyncCrudAppService<TEntity, TEntityDto, TPrimaryKey, TGetAllInput, TCreateInput, TUpdateInput>
        where TEntity : class, IEntity<TPrimaryKey>
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TUpdateInput : IEntityDto<TPrimaryKey>
    {
        protected zyGISAsyncCrudAppService(IRepository<TEntity, TPrimaryKey> repository)
            : base(repository)
        {

        }

        public virtual async Task<PagedResultDto<TEntityDto>> GetAllByQuery(TGetAllInput input, string filterJson)
        {
            var ser = new DataContractJsonSerializer(typeof(FilterGroup));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(filterJson));
            FilterGroup filter = (FilterGroup)ser.ReadObject(ms);
            

            CheckGetAllPermission();

            QueryableSearcher<TEntity> queryType = new QueryableSearcher<TEntity>(filter);
            Expression<Func<TEntity, bool>> exp = t=> 1 == 1;

            try
            {
                exp = queryType.Search();
            }
            catch(NullReferenceException nullExp)
            {
                throw nullExp;
            }

            var query = CreateFilteredQuery(input).Where(exp);

            var totalCount = await AsyncQueryableExecuter.CountAsync(query);

            query = ApplySorting(query, input);
            query = ApplyPaging(query, input);

            var entities = await AsyncQueryableExecuter.ToListAsync(query);

            return new PagedResultDto<TEntityDto>(
                totalCount,
                entities.Select(MapToEntityDto).ToList()
            );
        }
    }
}
