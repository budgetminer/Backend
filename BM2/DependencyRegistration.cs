using BM2.Business.Readers;
using BM2.Business.Writers;
using DataAccess;
using DataAccess.Uow;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BM2 {
    public static class DependencyRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            //readers & writers
            services.AddTransient<ICustomerReader, CustomerReader>();
            services.AddTransient<ICustomerWriter, CustomerWriter>();

            services.AddTransient<ITeamWriter, TeamWriter>();
            services.AddTransient<ITeamReader, TeamReader>();



            services.AddTransient<ITeamReader, TeamReader>();
            services.AddTransient<ITeamWriter, TeamWriter>();

            //Data Access Services
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<DbContext, BMContext>();



            return services;
        }
    }
}
