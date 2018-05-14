using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.Swagger.Model;
using Microsoft.Extensions.PlatformAbstractions;
using BM2.Options;
using DataAccess;
using BM2.DataAccess;
using System.IO;
using BM2.DataAccess.IdentityEntities;
using Microsoft.AspNetCore.Identity;
using BM2.Models.IdentityModels;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace BM2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        private const string SecretKey = "iNivDmHLpUA223sqsfhqGbMRdRj1PVkH"; //securize this
        private const string mainDb = @"Server=(localdb)\mssqllocaldb;Database=Miner;Trusted_Connection=True;";
        private const string identityDb = @"Server=(localdb)\mssqllocaldb;Database=Identity;Trusted_Connection=True;";
        private readonly SymmetricSecurityKey _signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(SecretKey));

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var jwtAppsettingOptions = Configuration.GetSection(nameof(JwtIssuerOptions));
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = jwtAppsettingOptions[nameof(JwtIssuerOptions.Issuer)],

                ValidateAudience = true,
                ValidAudience = jwtAppsettingOptions[nameof(JwtIssuerOptions.Audience)],

                ValidateIssuerSigningKey = true,
                IssuerSigningKey = _signingKey,

                RequireExpirationTime = false,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero
            };

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(configureOptions =>
            {
                configureOptions.ClaimsIssuer = jwtAppsettingOptions[nameof(JwtIssuerOptions.Issuer)];
                configureOptions.TokenValidationParameters = tokenValidationParameters;
                configureOptions.SaveToken = true;
            });

            //claims and policies
            services.AddAuthorization(options =>
            {
                options.AddPolicy("ApiUser", policy => policy.RequireClaim(Constants.Identity.JwtClaimIdentifiers.Rol, Constants.Identity.JwtClaims.ApiAccess));
                options.AddPolicy("Admin", policy => policy.RequireClaim(Constants.Identity.JwtClaimIdentifiers.Rol, Constants.Identity.JwtClaims.Admin));
            });

            //services
            services.AddBusinessServices();
            services.AddAutoMapper();
            services.AddDataAccess<BMContext>();
            services.AddDbContext<BMContext>(options => options.UseSqlServer(mainDb));
            services.AddDbContext<IdentityContext>(options => options.UseSqlServer(identityDb));

            services.AddIdentity<IdentityUser, IdentityRole>(opt =>
                {
                    opt.Password.RequireDigit = true;
                    opt.Password.RequiredLength = 8;
                    opt.Password.RequireNonAlphanumeric = false;
                    opt.Password.RequireLowercase = false;
                    opt.Password.RequireUppercase = false;
                })
                .AddEntityFrameworkStores<BMContext>()
                .AddDefaultTokenProviders();

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
                var xmlPath = Path.Combine(basePath, "BM2.xml");
                c.IncludeXmlComments(xmlPath);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCors(options =>
            {
                options.AllowAnyMethod();
                options.AllowAnyHeader();
                options.AllowAnyOrigin();
                options.AllowCredentials();
            });
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseSwagger();
            app.UseSwaggerUi();
        }
    }
}
