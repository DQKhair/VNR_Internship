using AutoMapper;
using Vnr_InsternShip_Assignment.Models;

namespace Vnr_InsternShip_Assignment.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<KhoaHoc,KhoaHocDTO>();
            CreateMap<KhoaHocDTO,KhoaHoc>();

            CreateMap<MonHoc,MonHocDTO>();
            CreateMap<MonHocDTO, MonHoc>();
        }
    }
}
