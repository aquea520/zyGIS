using zyGIS.Authorization.Users;
using AutoMapper;

namespace zyGIS.Form.Dto
{
    public class FormMapProfile : Profile
    {
        public FormMapProfile()
        {
            CreateMap<FormDto, Form>();

            CreateMap<CreateFormDto, Form>();
        }
    }
}
