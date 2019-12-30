using PointOfSalesV2.Common;
using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSalesV2.Repository.Helpers
{
   public class UsersHelper
    {
      
        public static void VerifyAdminUser(IDataRepositoryFactory dataRepositoryFactory)
        {
            var usersRepo = dataRepositoryFactory.GetDataRepositories<User>();
            var adminUser = usersRepo.Get(x => x.Where(y => y.UserName == "admin" && y.Active == true));
            if (adminUser == null) 
            {
                adminUser = new User()
                {
                    Active = true,
                    Address = "",
                    BirthDay = new DateTime(1900, 01, 01),
                    CreatedBy = new Guid(),
                    CreatedDate = DateTime.Now,
                    ContentType="",
                    CreatedByName="admin",
                    Email="admin@admin.com",
                    Gender='M',
                    LanguageCode = "EN",
                    UserName ="admin",
                    Password= MD5.Encrypt("Admin@123", "uJ0TLb5KVx5C2qzcCdKwsynac18KBQ06"),
                    LastName="admin",
                    Phone="8095555555",
                    Name="admin",
                    Mobile="8095555555",
                    
                  
                };
                usersRepo.Add(adminUser);
            }
        }

       

    }
}
