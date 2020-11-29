using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OData.Edm;
using Newtonsoft.Json;
using PointOfSalesV2.Entities;
using PointOfSalesV2.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;

namespace PointOfSalesV2.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            GetLanguageKeysJsonFile();
        }

        static int CountDays(DayOfWeek day, DateTime start, DateTime end)
        {
            TimeSpan ts = end - start;                       // Total duration
            int count = (int)Math.Floor(ts.TotalDays / 7);   // Number of whole weeks
            int remainder = (int)(ts.TotalDays % 7);         // Number of remaining days
            int sinceLastDay = (int)(end.DayOfWeek - day);   // Number of days since last [day]
            if (sinceLastDay < 0) sinceLastDay += 7;         // Adjust for negative days since last [day]

            // If the days in excess of an even week are greater than or equal to the number days since the last [day], then count this one, too.
            if (remainder >= sinceLastDay) count++;

            return count;
        }

        static int GetWeekNumberOfMonth(DateTime date)
        {
            date = date.Date;
            DateTime firstMonthDay = new DateTime(date.Year, date.Month, 1);
            DateTime firstMonthMonday = firstMonthDay.AddDays((DayOfWeek.Monday + 7 - firstMonthDay.DayOfWeek) % 7);
            if (firstMonthMonday > date)
            {
                firstMonthDay = firstMonthDay.AddMonths(-1);
                firstMonthMonday = firstMonthDay.AddDays((DayOfWeek.Monday + 7 - firstMonthDay.DayOfWeek) % 7);
            }
            return (date - firstMonthMonday).Days / 7 + 1;
        }

        public static int GetWeekOfMonth(DateTime date)
        {
            DateTime beginningOfMonth = new DateTime(date.Year, date.Month, 1);

            while (date.Date.AddDays(1).DayOfWeek != CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek)
                date = date.AddDays(1);

            return (int)Math.Truncate((double)date.Subtract(beginningOfMonth).TotalDays / 7f) + 1;
        }

        public static void GetLanguageKeysJsonFile()
        {
            var provider = StartDI();
            var toAdd = new List<LanguageKey>();
            var context = provider.GetService<MainDataContext>();
            var fileLines = System.IO.File.ReadAllLines("D:\\backup\\2020-11-28\\PointOfSalesV2\\PointOfSalesV2\\PointOfSalesV2.Common\\languagekeys.csv").Skip(1).ToList();
            var langKeysRepo = provider.GetService<IDataRepositoryFactory>().GetDataRepositories<LanguageKey>();
            var currentKeys = langKeysRepo.GetAll(x => x, y => y.Active == true);
            fileLines.ForEach(l =>
            {
                var keyValues = l.Split(",");

                LanguageKey languageKey = new LanguageKey()
                {
                    Active = true,
                    CreatedBy = new Guid(),
                    CreatedByName = "System",
                    CreatedDate = DateTime.Now,
                    Key = keyValues[1],
                    LanguageCode = keyValues[0],
                    LanguageId = Convert.ToInt32(keyValues[9]),
                    Value = keyValues[10]
                };
                if (!context.LanguageKeys.Any(x => x.LanguageCode.ToLower() == languageKey.LanguageCode.ToLower() && x.Key.ToLower() == languageKey.Key.ToLower())) 
                {
                    context.LanguageKeys.Add(languageKey);
                    context.SaveChanges();
                }
                

            });

            string result = JsonConvert.SerializeObject(langKeysRepo.GetAll().Data);
        }

        public static ServiceProvider StartDI()
        {
            string connectionString = "Server=SQL5097.site4now.net; Database=DB_A63AA6_lenytest;Persist Security Info=False;User ID=DB_A63AA6_lenytest_admin;Password=Marle@0712;Trusted_Connection=False;";
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
