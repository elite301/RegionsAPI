﻿using Data.Dtos;
using Data.Entities;

namespace RegionsAPI.Extensions
{
    public static class AutoMapperExtension
    {
        public static void InitializeAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(config =>
            {
                config.CreateMap<Region, RegionDto>().ReverseMap();
                config.CreateMap<Region, RegionSelectDto>().ReverseMap();

                config.CreateMap<Employee, EmployeeDto>().ReverseMap();
                config.CreateMap<Employee, EmployeeSelectDto>().ReverseMap();
            });
        }
    }
}
