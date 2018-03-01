using AutoMapper;

  
namespace zyGIS.TableConfigs.Dto
{
    public class TableConfigMapProfile : Profile
	{
		public TableConfigMapProfile()
        {
            CreateMap<TableConfigDto, TableConfig>();

            CreateMap<CreateTableConfigDto, TableConfig>();
        }
	}
}