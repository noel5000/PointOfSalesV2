using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using PointOfSalesV2.Common;
using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using static PointOfSalesV2.Common.Enums;

namespace PointOfSalesV2.EntityFramework
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<Operation> operations = new List<Operation>();
            foreach (var operation in Enum.GetValues(typeof(Operations)).Cast<Operations>().ToList())
            {
                operations.Add(new Operation()
                {
                    Id = (long)operation,
                    Name = operation.ToString(),
                    Active = true,
                    CreatedBy = new Guid("8A2FDD4A-E702-482C-F181-08D7015E3521"),
                    CreatedDate = DateTime.Now,
                    CreatedByName = "admin",
                    TranslationData = $"{(char)123}{(char)34}ES{(char)34}:[{(char)123}{(char)34}PropertyName{(char)34}:{(char)34}Name{(char)34},{(char)34}Value{(char)34}:{(char)34}{operation.ToString()}{(char)34}{(char)125}]{(char)125}," +
                    $"{(char)123}{(char)34}EN{(char)34}:[{(char)123}{(char)34}PropertyName{(char)34}:{(char)34}Name{(char)34},{(char)34}Value{(char)34}:{(char)34}{operation.ToString()}{(char)34}{(char)125}]{(char)125}"
                });
            }
            var paymentTypes = new List<PaymentType>();

            foreach (var paymentType in Enum.GetValues(typeof(PaymentTypes)).Cast<PaymentTypes>().ToList())
            {
                paymentTypes.Add(new PaymentType()
                {
                    Id = (long)paymentType,
                    Name = paymentType.ToString(),
                    Active = true,
                    Code = (short)paymentType,
                    CreatedBy = new Guid("8A2FDD4A-E702-482C-F181-08D7015E3521"),
                    CreatedDate = DateTime.Now,
                    CreatedByName = "admin",
                    TranslationData = $"{(char)123}{(char)34}ES{(char)34}:[{(char)123}{(char)34}PropertyName{(char)34}:{(char)34}Name{(char)34},{(char)34}Value{(char)34}:{(char)34}{paymentType.ToString()}{(char)34}{(char)125}]{(char)125}," +
                    $"{(char)123}{(char)34}EN{(char)34}:[{(char)123}{(char)34}PropertyName{(char)34}:{(char)34}Name{(char)34},{(char)34}Value{(char)34}:{(char)34}{paymentType.ToString()}{(char)34}{(char)125}]{(char)125}"
                });
            }

            var sequenceControls = new List<SequenceControl>();
            foreach (var sequence in Enum.GetValues(typeof(SequenceTypes)).Cast<SequenceTypes>().ToList())
            {
                sequenceControls.Add(new SequenceControl()
                {
                    Id = (long)sequence,
                    Name = sequence.ToString(),
                    Active = true,
                    NumericControl = 0,
                    Code = (short)sequence,
                    CreatedBy = new Guid("8A2FDD4A-E702-482C-F181-08D7015E3521"),
                    CreatedDate = DateTime.Now,
                    CreatedByName = "admin",
                    TranslationData = $"{(char)123}{(char)34}ES{(char)34}:[{(char)123}{(char)34}PropertyName{(char)34}:{(char)34}Name{(char)34},{(char)34}Value{(char)34}:{(char)34}{sequence.ToString()}{(char)34}{(char)125}]{(char)125}," +
                    $"{(char)123}{(char)34}EN{(char)34}:[{(char)123}{(char)34}PropertyName{(char)34}:{(char)34}Name{(char)34},{(char)34}Value{(char)34}:{(char)34}{sequence.ToString()}{(char)34}{(char)125}]{(char)125}"
                });
            }
            var movementTypes = new List<MovementType>();
            foreach (var movement in Enum.GetValues(typeof(MovementTypes)).Cast<MovementTypes>().ToList())
            {
                movementTypes.Add(new MovementType()
                {
                    Id = (long)movement,
                    Name = movement.ToString(),
                    Active = true,
                    Code = (short)movement,
                    CreatedBy = new Guid("8A2FDD4A-E702-482C-F181-08D7015E3521"),
                    CreatedDate = DateTime.Now,
                    CreatedByName = "admin",
                    TranslationData = $"{(char)123}{(char)34}ES{(char)34}:[{(char)123}{(char)34}PropertyName{(char)34}:{(char)34}Name{(char)34},{(char)34}Value{(char)34}:{(char)34}{movement.ToString()}{(char)34}{(char)125}]{(char)125}," +
                    $"{(char)123}{(char)34}EN{(char)34}:[{(char)123}{(char)34}PropertyName{(char)34}:{(char)34}Name{(char)34},{(char)34}Value{(char)34}:{(char)34}{movement.ToString()}{(char)34}{(char)125}]{(char)125}"
                });
            }
            int count = 0;
            var sectionOperations = new List<SectionOperation>();
            var sections = new List<Section>();
            foreach (var section in Enum.GetValues(typeof(AppSections)).Cast<AppSections>().ToList())
            {
                count++;
                sections.Add(new Section()
                {
                    Id = (long)section,
                    Name = section.ToString(),
                    Active = true,
                    Controllers=Enums.SectionsControllers[section],
                    CreatedBy = new Guid("8A2FDD4A-E702-482C-F181-08D7015E3521"),
                    CreatedDate = DateTime.Now,
                    CreatedByName = "admin",
                    TranslationData = $"{(char)123}{(char)34}ES{(char)34}:[{(char)123}{(char)34}PropertyName{(char)34}:{(char)34}Name{(char)34},{(char)34}Value{(char)34}:{(char)34}{section.ToString()}{(char)34}{(char)125}]{(char)125}," +
                    $"{(char)123}{(char)34}EN{(char)34}:[{(char)123}{(char)34}PropertyName{(char)34}:{(char)34}Name{(char)34},{(char)34}Value{(char)34}:{(char)34}{section.ToString()}{(char)34}{(char)125}]{(char)125}"
                });

                foreach (var operation in operations)
                {
                    sectionOperations.Add(new SectionOperation()
                    {
                        Active = true,
                        CreatedBy = new Guid(),
                        CreatedByName = "admin",
                        CreatedDate = DateTime.Now,
                        OperationId = operation.Id,
                        SectionId = (long)section,
                        Id = count
                    });
                    count++;
                }
            }

            modelBuilder.Entity<User>().HasData(new User()
            {
                UserId = new Guid("8A2FDD4A-E702-482C-F181-08D7015E3521"),
                Active = true,
                Address = "",
                BirthDay = new DateTime(1900, 01, 01),
                CreatedBy = new Guid(),
                CreatedDate = DateTime.Now,
                ContentType = "",
                CreatedByName = "admin",
                Email = "admin@admin.com",
                Gender = 'M',
                UserName = "admin",
                Password = MD5.Encrypt("Admin@123", "uJ0TLb5KVx5C2qzcCdKwsynac18KBQ06"),
                LastName = "admin",
                Phone = "8095555555",
                Name = "admin",
                LanguageCode="EN",
            
                Mobile = "8095555555",


            });
            var languages = new Language[]{
                new Language()
            {
                Active = true,
                Id = 1,
                Code = "EN",
                CreatedBy = new Guid(),
                CreatedByName = "admin",
                CreatedDate = DateTime.Now,
                Name = "English",
                    TranslationData = $"{(char)123}{(char)34}ES{(char)34}:[{(char)123}{(char)34}PropertyName{(char)34}:{(char)34}Name{(char)34},{(char)34}Value{(char)34}:{(char)34}ENGLISH{(char)34}{(char)125}]{(char)125}," +
                    $"{(char)123}{(char)34}EN{(char)34}:[{(char)123}{(char)34}PropertyName{(char)34}:{(char)34}Name{(char)34},{(char)34}Value{(char)34}:{(char)34}ENGLISH{(char)34}{(char)125}]{(char)125}"
            } ,
             new Language()
            {
                Active = true,
                Id = 2,
                Code = "ES",
                CreatedBy = new Guid(),
                CreatedByName = "admin",
                CreatedDate = DateTime.Now,
                Name = "Spanish",
                    TranslationData = $"{(char)123}{(char)34}ES{(char)34}:[{(char)123}{(char)34}PropertyName{(char)34}:{(char)34}Name{(char)34},{(char)34}Value{(char)34}:{(char)34}SPANISH{(char)34}{(char)125}]{(char)125}," +
                    $"{(char)123}{(char)34}EN{(char)34}:[{(char)123}{(char)34}PropertyName{(char)34}:{(char)34}Name{(char)34},{(char)34}Value{(char)34}:{(char)34}SPANISH{(char)34}{(char)125}]{(char)125}"
            }

            };
            modelBuilder.Entity<Language>().HasData(languages);
            var basicLanguageKeys = new List<LanguageKey>();
            foreach (var language in languages) 
            {
                basicLanguageKeys.AddRange(new List<LanguageKey>() { 
                    new LanguageKey() 
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="unitNotExist_msg",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Unit does not exist."
                    } ,
                    new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="parentUnitDoesntExist_msg",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Parent unit does not exist."
                    } ,
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="ok_msg",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Operation completed successfully."
                    } ,
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="error_msg",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Error: Could not completed the current operation. "
                    } ,
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="cannotUpdatePayment_msg",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Cannot update payment. "
                    } ,
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="invalidInvoice_msg",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Invalid invoice."
                    } ,
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="owedAmountOutdated_msg",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Owed amount is outdated. please try update and try again."
                    } ,
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="invoicePaid_msg",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Invoice is already paid."
                    } ,
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="paymentNotValid_msg",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Payment is not valid."
                    } ,
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="emptyInvoice_msg",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Invoice doesn't have any details. Cannot be empty."
                    } ,
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="creditLimitReached_msg",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Credit limit reached. Cannot continue."
                    } ,
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="trnNotAvailable_msg",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="TRN is not available."
                    } ,
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="outOfStock_msg",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Product is out of stock."
                    } ,
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="defWarehouseNotExit_msg",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Defective warehouse does not exist. Please create one with 'DEF' as code first. "
                    } ,
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="notExistingClass_msg",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Cannot process this product/Service. Class does not exist."
                    } ,
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="warehouseError_msg",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Warehouse does not exist."
                    } ,
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="creditNoteNotExist_msg",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Credit note does not exist. "
                    } ,
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="creditNoteApplied_msg",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Credit note is already applied."
                    } ,
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="differentCurrency_msg",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Currencies are different. You can only apply the same currency. "
                    } ,
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="amountIsGreater_msg",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Credit note amount is greater than invoice amount."
                    } ,
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="productNeedsUnits_msg",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Product needs at least one unit."
                    } ,
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="productNeedsPrimaryUnit_msg",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Product needs one primary unit."
                    } ,
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="cannotEraseUnit_msg",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Cannot erase product unit."
                    } ,
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="cannotDeleteTax_msg",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Cannot delete product tax. "
                    } ,
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="cannotRemoveBaseProduct_msg",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Cannot remove base product."
                    } ,
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="sequenceError_msg",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Sequence Error."
                    },
//menu keys
new LanguageKey()

                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="start_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Start"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="user_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="User"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="changePass_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Change Password"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="login_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Login"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="logOut_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Log out"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="resetPass_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Reset Password"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="core_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Configurations"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="branchOffice_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Branch Offices"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="warehouse_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Warehouses"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="currencies_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Currencies"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="suppliers_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Suppliers"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="taxes_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Taxes"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="units_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Units"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="TRNControl_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="TRN Control"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="zones_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Zones"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="sellers_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Sellers"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="customers_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Customers"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="products_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Products"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="cashRegister_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Cash Registers"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="cashRegisterManteinance_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Manteinance"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="cashROpenClose_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Opening/Closing"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="billing_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Billing"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="quotes_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Quotes"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="invoices_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Invoices"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="customerPayment_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Payments"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="expenses_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Expenses"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="expensesRegister_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Register expenses"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="expensesPayment_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Payments"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="reports_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Reports"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="sales_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Sales"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="accountsReceivable_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Accounts Receivable"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="incomeReceipts_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Income Receipts"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="commissions_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Commissions"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="inventory_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Inventory"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="productsMovements_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Products Movements"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="debtsToPay_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Debts To Pay"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="pricesList_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Prices List"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="customersList_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Customers List"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="accountState_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Account State"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="movements_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Movements"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="resultState_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Result State"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="taxesReport_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Taxes Report"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="inventoryIn_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Inventory Incomes"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="warehouseTransfers_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Warehouses Transfers"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="suppliersReturns_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Suppliers Returns"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="auth_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Auth"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="users_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Users"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="roles_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Roles"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="profile_btn",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Profile"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="logOut_btn",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Log Out"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="dashboard_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Dashboard"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="remember_msg",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Remember me?"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="forgotPass_msg",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Forgot Password?"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="password_input",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Password"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="email_input",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Email"
                    },
new LanguageKey()
                    {
                    Active=true,
                    CreatedBy=new Guid(),
                    CreatedByName="admin",
                    CreatedDate=DateTime.Now,
                    Key="customersReturns_menu",
                    LanguageId=language.Id,
                    LanguageCode=language.Code,
                    Value="Customers Returns"
                    }
// new system keys goes here


                });
            }

         //   var repeatedKeys = basicLanguageKeys.GroupBy(x => x.Key).ToList().Where(x=>x.Count()>2).Select(x=>x.Key).ToList();

            
            modelBuilder.Entity<Operation>().HasData(operations);
            modelBuilder.Entity<PaymentType>().HasData(paymentTypes);
            modelBuilder.Entity<SequenceControl>().HasData(sequenceControls);
            modelBuilder.Entity<MovementType>().HasData(movementTypes);
            modelBuilder.Entity<Section>().HasData(sections);
            modelBuilder.Entity<SectionOperation>().HasData(sectionOperations);
            modelBuilder.Entity<LanguageKey>().HasData(basicLanguageKeys);

        }

       
    }
}
