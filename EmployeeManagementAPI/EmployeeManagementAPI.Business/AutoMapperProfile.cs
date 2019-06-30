using AutoMapper;
using EmployeeManagementAPI.Models.Models;
using EmployeeManagementAPI.Repository.Entities;


namespace EmployeeManagementAPI.Business
{
    class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<EmployeeDetails, EmployeeDetailsModel>();
            CreateMap<EmployeeDetailsModel, EmployeeDetails>();
        }
    }
}
