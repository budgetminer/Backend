using BM2.Business;
using BM2.Business.Base;
using BM2.Business.Readers;
using BM2.Business.Writers;
using BM2.DataAccess;
using Digipolis.DataAccess;
using Digipolis.DataAccess.Uow;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BM2
{
    public static class DependencyRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddTransient<ICustomerReader, CustomerReader>();
            services.AddTransient<ICustomerWriter, CustomerWriter>();

            //Data Access Services
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<DbContext, EntityContext>();


            return services;
        }
    }
}
