using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using zyGIS.Authorization.Users;

namespace zyGIS.Form.Dto
{
    [AutoMapFrom(typeof(Form))]
    public class FormDto : EntityDto<Guid>
    {
        [Required]
        [StringLength(AbpUserBase.MaxNameLength)]
        public string Name { get; set; }
    }
}