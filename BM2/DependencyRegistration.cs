using BudgetMiner.Business.Readers;
using BudgetMiner.Business.Readers.Definitions;
using BudgetMiner.Business.Writers;
using BudgetMiner.Business.Writers.Definitions;
using DataAccess;
using DataAccess.Uow;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BudgetMiner
{
    public static class DependencyRegistration
    {
        /// <summary>
        /// Business service registration
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            //readers & writers
            services.AddTransient<ICustomerReader, CustomerReader>();
            services.AddTransient<ICustomerWriter, CustomerWriter>();

            services.AddTransient<ITeamWriter, TeamWriter>();
            services.AddTransient<ITeamReader, TeamReader>();

            services.AddTransient<IComponentReader, ComponentReader>();
            services.AddTransient<IComponentWriter, ComponentWriter>();

            services.AddTransient<ICostsReader, CostsReader>();
            services.AddTransient<ICostsWriter, CostsWriter>();

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
