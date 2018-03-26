﻿using BM2.Business;
using BM2.Business.Readers;
using BM2.Business.Writers;
using Microsoft.Extensions.DependencyInjection;

namespace BM2
{
    public static class DependencyRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddTransient<ICustomerReader, CustomerReader>();
            services.AddTransient<ICustomerWriter, CustomerWriter>();

            services.AddTransient<ILevelsReader, LevelsReader>();
            services.AddTransient<ILevelsWriter, LevelsWriter>();

            services.AddTransient<ITeamReader, TeamReader>();
            services.AddTransient<ITeamWriter, TeamWriter>();

            return services;
        }
    }
}
