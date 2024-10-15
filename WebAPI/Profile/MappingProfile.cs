using AutoMapper;
using WebAPI.Models;
using WebAPI.Models;

namespace WebAPI.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CompanyRevenue, CompanyRevenue>(); 
        }
    }
}
