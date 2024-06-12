using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects;

namespace MiddlewareExample
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        { 
            CreateMap<Company, CompanyDto>()
                .ForCtorParam("FullAddress",
                opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));
            
            CreateMap<Employee, EmployeeDto>();

            CreateMap<EmployeeForCreationDto, Employee>();

            CreateMap<CompanyForCreationDto, Company>();

            CreateMap<EmployeeForUpdateDto, Employee>().ReverseMap();

            CreateMap<CompanyForUpdateDto, Company>();
        }
    }
}
