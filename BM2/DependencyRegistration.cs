using BM2.Business.Readers;
using BM2.Business.Writers;
using BM2.DataAccess;
using DataAccess;
using DataAccess.Uow;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BM2
{
    public static class DependencyRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            //readers & writers
            services.AddTransient<ICustomerReader, CustomerReader>();
            services.AddTransient<ICustomerWriter, CustomerWriter>();
            services.AddTransient<ITeamReader, TeamReader>();
            services.AddTransient<IHeadCountReader, HeadCountReader>();
            services.AddTransient<ITeamWriter, TeamWriter>();
            services.AddTransient<IHeadCountWriter, HeadCountWriter>();
        
            services.AddTransient<ICotyWriter, CostTypeWriter>();
            services.AddTransient<ICuWriter, CuWriter>();
            services.AddTransient<ILicenseWriter, LicenseWriter>();
            services.AddTransient<ILicenseCostWriter, LicenseCostWriter>();
            services.AddTransient<ILicenseTypeWriter, LicenseTypeWriter>();

            services.AddTransient<ICostTypeReader, CostTypeReader>();
            services.AddTransient<ICuReader, CuReader>();
            services.AddTransient<ILicenseReader, LicenseReader>();
            services.AddTransient<ILicenseCostReader, LicenseCostReader>();
            services.AddTransient<ILicenseTypeReader, LityReader>();

            services.AddTransient<ILevelsReader, LevelsReader>();
            services.AddTransient<ILevelsWriter, LevelsWriter>();

            services.AddTransient<ITeamReader, TeamReader>();
            services.AddTransient<ITeamWriter, TeamWriter>();

            //Data Access Services
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<DbContext, EntityContext>();



            return services;
        }
    }
}
