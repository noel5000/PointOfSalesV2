﻿using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OData.Edm;
using Newtonsoft.Json;
using PointOfSalesV2.Entities;
using PointOfSalesV2.Repository;
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;

namespace PointOfSalesV2.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var algo = DateTime.Now;
            var today = algo.DayOfWeek;
            var startOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var endOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, 1).AddDays(-1);
            
            var daysCount = CountDays(DayOfWeek.Monday, startOfMonth, endOfMonth);
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
