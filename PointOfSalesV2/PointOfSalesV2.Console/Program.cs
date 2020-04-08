using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using PointOfSalesV2.Entities;
using PointOfSalesV2.Repository;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace PointOfSalesV2.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            GetLanguageKeysJsonFile();
        }

        public static void GetLanguageKeysJsonFile()
        {
            var provider = StartDI();
            var context = provider.GetService<MainDataContext>();
            var fileLines = System.IO.File.ReadAllLines("C:\\Users\\noelj\\OneDrive\\traducciones.csv").ToList();
            var langKeysRepo = provider.GetService<IDataRepositoryFactory>().GetDataRepositories<LanguageKey>();
            var currentKeys = langKeysRepo.GetAll(x => x, y => y.Active == true);
            fileLines.ForEach(l =>
            {
                var keyValues = l.Split(",");
                if (keyValues[0] != "Key")
                {
                    LanguageKey spanishKey = new LanguageKey()
                    {
                        CreatedBy = new System.Guid(),
                        CreatedDate = new DateTime(2000, 1, 1),
                        Active = true,
                        CreatedByName = "admin",
                        Key = keyValues[0],
                        LanguageCode = "ES",
                        LanguageId = 2,
                        Value = keyValues[1]
                    };
                    LanguageKey englishKey = new LanguageKey()
                    {
                        CreatedBy = new System.Guid(),
                        CreatedDate = new DateTime(2000, 1, 1),
                        Active = true,
                        CreatedByName = "admin",
                        Key = keyValues[0],
                        LanguageCode = "EN",
                        LanguageId = 1,
                        Value = keyValues[2]
                    };
                    if (!currentKeys.Data.Any(x =>  x.Key == spanishKey.Key))
                    {
                        context.LanguageKeys.AddRange(spanishKey, englishKey);
                        context.SaveChanges();
                    }
                   
                }

            });

            string result = JsonConvert.SerializeObject(langKeysRepo.GetAll().Data);
        }

        public static ServiceProvider StartDI()
        {
            string connectionString = "Server=localhost;Database=ComedoresEconomicos;Trusted_Connection=True;";
            ServiceProvider serviceProvider = new ServiceCollection()
                  .AddDbContext<MainDataContext>(options =>
                  {
                      var connection = new SqlConnection(connectionString);
                      options.UseSqlServer(connection);

                  })
           .AddLogging()
           .AddMemoryCache()
           .AddSingleton<IHttpContextAccessor, HttpContextAccessor>()
           .AddSingleton<IUnitOfWork, UnitOfWork>()
           .AddSingleton<IDataRepositoryFactory, DataRepositoriesFactory>()
           .AddTransient(typeof(IBase<>), typeof(Repository<>))

           .BuildServiceProvider();
            return serviceProvider;
        }
    }
}
