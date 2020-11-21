
using System;
using System.Linq;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using PointOfSalesV2.Entities.Model;
using PointOfSalesV2.Repository;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using PointOfSalesV2.Api.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using Microsoft.AspNetCore.Mvc;
using PointOfSalesV2.Entities;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json.Serialization;
using System.Text.Json;

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
           
            services.AddControllers(mvcOptions =>
            {
                mvcOptions.EnableEndpointRouting = false;
            });
            services.AddControllersWithViews();
            services.AddOData();
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
            TranslateUtility.SetHttpContext(services.BuildServiceProvider().GetService<IHttpContextAccessor>());
            services.AddSingleton<IFileProvider>(
               new PhysicalFileProvider(
                   Path.Combine(Directory.GetCurrentDirectory(), "")));

            services.AddScoped<IBranchOfficeRepository, BranchOfficeRepository>();
            services.AddScoped<ICashRegisterOpeningRepository, CashRegisterOpeningRepository>();
            services.AddScoped<IRoleSectionOperationRepository, RoleSectionOperationRepository>();
            services.AddScoped<ISellerRepository, SellerRepository>();
            services.AddScoped<ISequenceManagerRepository, SequenceManagerRepository>();
            services.AddScoped<ICompanyPaymentRepository, CompanyPaymentRepository>();
            services.AddScoped<ILanguageKeyRepository, LanguageKeyRepository>();
            services.AddScoped<IBusinessStateRepository, BusinessStateRepository>();
            services.AddScoped<ICompositeProductRepository, CompositeProductRepository>();
            services.AddScoped<ICreditNoteRepository, CreditNoteRepository>();
            services.AddScoped<ICustomerBalanceRepository, CustomerBalanceRepository>();
            services.AddScoped<ICustomerReturnRepository, CustomerReturnRepository>();
            services.AddScoped<ICustomerPaymentRepository, CustomerPaymentRepository>();
            services.AddScoped<IExpenseRepository, ExpenseRepository>();
            services.AddScoped<IExpensesPaymentRepository, ExpensesPaymentRepository>();
            services.AddScoped<IInventoryEntryRepository, InventoryEntryRepository>();
            services.AddScoped<IExpenseTaxRepository, ExpenseTaxRepository>();
            services.AddScoped<IInventoryRepository, InventoryRepository>();
            services.AddScoped<IInvoiceDetailRepository, InvoiceDetailRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            services.AddScoped<IInvoiceTaxRepository, InvoiceTaxRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductTaxRepository, ProductTaxRepository>();
            services.AddScoped<ISupplierReturnRepository, SupplierReturnRepository>();
            services.AddScoped<IUnitProductEquivalenceRepository, UnitProductEquivalenceRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IWarehouseMovementRepository, WarehouseMovementRepository>();
            services.AddScoped<IWarehouseRepository, WarehouseRepository>();
            services.AddScoped<IWarehouseTransferRepository, WarehouseTransferRepository>();
            services.AddScoped<IMenuRepository, MenuRepository>();
            services.AddScoped<ISchoolRepository, SchoolRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IDataRepositoryFactory, DataRepositoriesFactory>();

            //New instance for injection
            services.AddTransient(typeof(IBase<>), typeof(Repository<>));

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
            services.AddMvc(a => { });

            services.AddControllers().AddNewtonsoftJson(options =>
     options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
 );


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }
            //app.UseRouting();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "api/{controller}/{action=Index}/{id?}");
            //});

            app.UseMvcWithDefaultRoute();
            app.UseCors("AllowAllOrigins");

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseMvc(routerBuilder =>
            {
                routerBuilder.EnableDependencyInjection();
                routerBuilder.Expand().Select().Filter().Count().MaxTop(null).OrderBy();
                routerBuilder.MapODataServiceRoute("odata", "odata", OdataHelper.GetEdmModel(app));
                routerBuilder.MapODataServiceRoute("odata/exporttoexcel", "odata/exporttoexcel", OdataHelper.GetEdmModel(app));

            });



        }


    }
}
