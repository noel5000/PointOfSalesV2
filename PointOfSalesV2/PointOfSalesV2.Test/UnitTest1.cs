using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PointOfSalesV2.Entities;
using PointOfSalesV2.Entities.Model;
using PointOfSalesV2.Repository;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System.IO;
using PointOfSalesV2.Common;
using System.Linq;
using Microsoft.OData.Edm;
using Newtonsoft.Json;

namespace PointOfSalesV2.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            GetLanguageKeysJsonFile();
        }

        public void GetLanguageKeysJsonFile() 
        {
            var provider = this.StartDI();
            var fileLines = System.IO.File.ReadAllLines("C:\\Users\\noelj\\OneDrive\\traducciones.csv").ToList();
            var langKeysRepo = provider.GetService<IDataRepositoryFactory>().GetDataRepositories<LanguageKey>();
            var currentKeys = langKeysRepo.GetAll(x => x, y => y.Active == true);
            fileLines.ForEach(l => {
                var keyValues = l.Split(",");
                if (keyValues[0] != "Key")
                {
                    LanguageKey spanishKey = new LanguageKey()
                    {
                        CreatedBy = new System.Guid(),
                        CreatedDate = new Date(2000, 1, 1),
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
                        CreatedDate = new Date(2000, 1, 1),
                        Active = true,
                        CreatedByName = "admin",
                        Key = keyValues[0],
                        LanguageCode = "ES",
                        LanguageId = 1,
                        Value = keyValues[2]
                    };
                    if (!currentKeys.Data.Any(x => x.LanguageCode == spanishKey.LanguageCode && x.Key == spanishKey.Key))
                    {
                        langKeysRepo.Add(spanishKey);
                    }
                    if (!currentKeys.Data.Any(x => x.LanguageCode == englishKey.LanguageCode && x.Key == englishKey.Key))
                    {
                        langKeysRepo.Add(englishKey);
                    }
                }
               
            });

            string result = JsonConvert.SerializeObject(langKeysRepo.GetAll().Data);
        }

        public ServiceProvider StartDI() 
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
