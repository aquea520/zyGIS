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
using zyGIS.Form.Dto;
using System;
using zyGIS.Roles.Dto;
using zyGIS.Authorization.Roles;
using System.Collections.Generic;

namespace zyGIS.Form
{
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class FormAppService : AsyncCrudAppService<Form, FormDto, Guid, PagedResultRequestDto, CreateFormDto, FormDto>, IFormAppService
    {
        private readonly IRepository<Role> _roleRepository;
        public FormAppService(
            IRepository<Form, Guid> repository,
            IRepository<Role> roleRepository)
            : base(repository)
        {

            _roleRepository = roleRepository;
        }

        public override async Task<FormDto> Create(CreateFormDto input)
        {
            CheckCreatePermission();

            var Form = ObjectMapper.Map<Form>(input);

            await Repository.InsertAsync(Form);

            CurrentUnitOfWork.SaveChanges();

            return MapToEntityDto(Form);
        }

        public async Task<ListResultDto<RoleDto>> GetRoles()
        {
            var roles = await _roleRepository.GetAllListAsync();
            return new ListResultDto<RoleDto>(ObjectMapper.Map<List<RoleDto>>(roles));
        }

        protected override Form MapToEntity(CreateFormDto createInput)
        {
            var Form = ObjectMapper.Map<Form>(createInput);
            return Form;
        }

        protected override void MapToEntity(FormDto input, Form Form)
        {
            ObjectMapper.Map(input, Form);
        }

        protected override FormDto MapToEntityDto(Form Form)
        {
            var formDto = base.MapToEntityDto(Form);
            return formDto;
        }

        protected override IQueryable<Form> CreateFilteredQuery(PagedResultRequestDto input)
        {
            return Repository.GetAll();
        }

        protected override async Task<Form> GetEntityByIdAsync(Guid id)
        {
            return await Repository.GetAll().FirstOrDefaultAsync(x => x.Id == id);
        }

        protected override IQueryable<Form> ApplySorting(IQueryable<Form> query, PagedResultRequestDto input)
        {
            return query.OrderBy(r => r.Name);
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}