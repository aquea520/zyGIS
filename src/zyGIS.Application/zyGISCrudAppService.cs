using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Stbis.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public virtual async Task<PagedResultDto<TEntityDto>> GetAllByQuery(TGetAllInput input, FilterGroup filter)
        {
            FilterRule rule = new FilterRule()
            {
                field = "age",
                op = "equal",
                type = "number",
                value = ""
            };
            filter.rules.Add(rule);

            CheckGetAllPermission();

            QueryableSearcher<TEntity> queryType = new QueryableSearcher<TEntity>(filter);
            Expression<Func<TEntity, bool>> exp = queryType.Search();

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
