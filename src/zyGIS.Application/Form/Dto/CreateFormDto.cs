using System.ComponentModel.DataAnnotations;
using Abp.Auditing;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using Abp.Runtime.Validation;
using zyGIS.Authorization.Users;
using zyGIS.Form;

namespace zyGIS.Form.Dto
{
    [AutoMapTo(typeof(Form))]
    public class CreateFormDto : IShouldNormalize
    {

        [Required]
        [StringLength(AbpUserBase.MaxNameLength)]
        public string Name { get; set; }

        public void Normalize()
        {

        }
    }
}