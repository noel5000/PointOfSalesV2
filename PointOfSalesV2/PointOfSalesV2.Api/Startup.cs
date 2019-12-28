

using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.OData.Edm;
using Newtonsoft.Json.Serialization;
using PointOfSalesV2.Entities;
using PointOfSalesV2.Entities.Model;
using PointOfSalesV2.Repository;
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
//using Microsoft.AspNetCore.Mvc.Cors.Internal;

namespace PointOfSalesV2.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMemoryCache();
            var appSettings = Configuration.GetSection("AppSettings").Get<AppSettings>();
            var connections = Configuration.GetSection("ConnectionStrings").Get<ConnectionStrings>();
            services.AddDbContext<MainDataContext>(options =>
            {
                var connection = new SqlConnection(connections.Main);
                options.UseSqlServer(connection);

            });
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<IFileProvider>(
               new PhysicalFileProvider(
                   Path.Combine(Directory.GetCurrentDirectory(), "")));


            //services.AddScoped<IParqueoRepository, ParqueoRepository>();
            //services.AddScoped<IStockRepository, StockRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IDataRepositoryFactory, DataRepositoriesFactory>();

            //New instance for injection
            services.AddTransient(typeof(IBase<>), typeof(Repository<>));
            // Add Culture
            var cultureInfo = new CultureInfo("es-DO");
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
             options.TokenValidationParameters = new TokenValidationParameters
             {
                 ValidateIssuer = true,
                 ValidateAudience = true,
                 ValidateLifetime = true,
                 ValidateIssuerSigningKey = true,
                 ValidIssuer = appSettings.Domain,
                 ValidAudience = appSettings.Domain,
                 IssuerSigningKey = new SymmetricSecurityKey(
                 Encoding.UTF8.GetBytes(appSettings.TokenKey)),
                 ClockSkew = TimeSpan.Zero
             });
            services.AddCors(o => o.AddPolicy("AllowAllOrigins", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));
           // services.AddOData();
            services.AddMvc().AddXmlSerializerFormatters();
            //services.AddMvc().AddJsonOptions(opt =>
            //{
            //    opt.SerializerSettings.ContractResolver = new DefaultContractResolver();
            //    opt.SerializerSettings.DateFormatString = "dd/MM/yyyy";
            //    opt.SerializerSettings.Culture = cultureInfo;
            //});

            //Esto para no terner que poner el attributo a cada metodo de controlado
            //para que permita crosorgine [EnableCors("AllowAllOrigins")]
            services.Configure<MvcOptions>(options =>
            {
                options.EnableEndpointRouting = false;
              //  options.Filters.Add(new CorsAuthorizationFilterFactory("AllowAllOrigins"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseCors("AllowAllOrigins");
            app.UseAuthentication();

            app.UseMvc(routes =>
            {

                //    routes.Select().Expand().Filter().OrderBy().MaxTop(null).Count();
                //    routes.MapODataServiceRoute("odata", "odata", GetEdmModel(app));
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });
            //app.UseMvc(routeBuilder => routeBuilder.EnableDependencyInjection());

        
        }

        private static IEdmModel GetEdmModel(IApplicationBuilder app)
        {
         ODataConventionModelBuilder builder = new ODataConventionModelBuilder(app.ApplicationServices);
            builder.EntitySet<Invoice>("Invoices");
            builder.EntitySet<InvoiceDetail>("InvoiceDetails");
            builder.EntitySet<Product>("Products").EntityType.HasKey(p => p.Id)
               .Filter(QueryOptionSetting.Allowed);
            //builder.EntitySet<Stock>("Stocks");
            //builder.EntitySet<User>("Users");
            return builder.GetEdmModel();
        }
    }
}
