using AutoMapper;
using BudgetMiner.DataAccess.IdentityEntities;
using BudgetMiner.Models;
using BudgetMiner.Models.IdentityModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace BudgetMiner {
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
                CreateMap<DataAccess.IdentityEntities.Customer, Customer>();
                CreateMap<RegistrationViewModel, IdentityUser>()
                    .ForMember(user => user.UserName, opt => opt.MapFrom(model => model.UserName));
            }
        }
    }
}