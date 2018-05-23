using BM2.Business.Readers;
using BM2.Business.Readers.Definitions;
using BM2.Business.Writers;
using BM2.Business.Writers.Definitions;
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

            services.AddTransient<ITeamWriter, TeamWriter>();
            services.AddTransient<ITeamReader, TeamReader>();

            services.AddTransient<IComponentReader, ComponentReader>();
            services.AddTransient<ICostsReader, CostsReader>();
            services.AddTransient<IComponentWriter, ComponentWriter>();
            services.AddTransient<IIndividualReader, IndividualReader>();
            services.AddTransient<IIndividualWriter, IndividualWriter>();
            services.AddTransient<IPartsReader, PartsReader>();
            services.AddTransient<IPartsWriter, PartsWriter>();
            services.AddTransient<IStacklayerReader, StacklayerReader>();
            services.AddTransient<IStacklayerWriter, StacklayerWriter>();
            services.AddTransient<IPartsGroupReader, PartsGroupReader>();
            services.AddTransient<IPartsGroupWriter, PartsGroupWriter>();


            services.AddTransient<ITeamReader, TeamReader>();
            services.AddTransient<ITeamWriter, TeamWriter>();

            //Data Access Services
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<DbContext, BMContext>();



            return services;
        }
    }
}
