﻿using AutoMapper;
using BM2.Models.ViewModels;
using BudgetMiner.DataAccess.BMEntities;
using BudgetMiner.Models.IdentityModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace BudgetMiner
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
                CreateMap<DataAccess.IdentityEntities.Customer, DataAccess.BMEntities.Customer>();
                CreateMap<RegistrationViewModel, IdentityUser>()
                    .ForMember(user => user.UserName, opt => opt.MapFrom(model => model.UserName));
                CreateMap<PartsGroup, PartsGroupModel>();
                CreateMap<Part, PartModel>();
                CreateMap<Costs, CostModel>();
                CreateMap<PartType, PartsTypeModel>();
                CreateMap<CostType, CostTypeModel>();
                CreateMap<Individual, IndividualModel>();
            }
        }

    }
}