using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using BM2.DataAccess;
using Swashbuckle.Swagger.Model;
using Microsoft.Extensions.PlatformAbstractions;
using BM2.Options;
using DataAccess;

namespace BM2
{
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        private const string connectionLocal = @"Server=(localdb)\mssqllocaldb;Database=BM;Trusted_Connection=True;";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {


            //services
            services.AddBusinessServices();
            services.AddAutoMapper();
            services.AddDataAccess<EntityContext>();
            services.AddDbContext<EntityContext>(options => options.UseSqlServer(connectionLocal));

            services.AddCors();
            services.AddMvc();
            services.AddSwaggerGen(c =>
            {
                c.SingleApiVersion(new Info
                {
                    Version = "v1",
                    Title = "Budgetminer",
                    Description = "Budgetminer api",
                    Contact = new Contact
                    {
                        Email = "",
                        Name = "",
                        Url = "",
                    }
                });
                c.DocumentFilter<LowerCaseFilter>();
                var basePath = PlatformServices.Default.Application.ApplicationBasePath;
                //var xmlPath = Path.Combine(basePath, "WetgevingApi.xml");
                //c.IncludeXmlComments(xmlPath);
            });
        }

            // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCors(options => {
                options.AllowAnyMethod();
                options.AllowAnyHeader();
                options.AllowAnyOrigin();
                options.AllowCredentials();
            });
            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseSwagger();
            app.UseSwaggerUi();
        }
    }
}
