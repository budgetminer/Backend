using AutoMapper;
using BM2.DataAccess.Entities;
using BM2.Models;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace BM2
{
    public static class AutoMapperRegistration
    {
        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            Mapper.Initialize(cfg =>
            {

                cfg.CreateMap(typeof(IEnumerable<>), typeof(List<>));
                cfg.CreateMap(typeof(List<>), typeof(List<>));
                cfg.CreateMap(typeof(ICollection<>), typeof(List<>));

                cfg.AddProfile(typeof(EntitiesToModels));

            });

            services.AddSingleton(Mapper.Configuration);

            return services;
        }

        class EntitiesToModels : Profile
        {
            public EntitiesToModels()
            {
                CreateMap(typeof(Team), typeof(TeamModel)).ReverseMap();
                CreateMap(typeof(Customer), typeof(CustomerModel)).ReverseMap();
                CreateMap(typeof(HeadCount), typeof(HeadCountModel)).ReverseMap();
                CreateMap(typeof(Level), typeof(LevelModel)).ReverseMap();
            }
        }
    }
}