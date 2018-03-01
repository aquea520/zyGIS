using AutoMapper;

  
namespace zyGIS.Peoples.Dto
{
    public class PeopleMapProfile : Profile
	{
		public PeopleMapProfile()
        {
            CreateMap<PeopleDto, People>();

            CreateMap<CreatePeopleDto, People>();
        }
	}
}