using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Common
{
    public class Enums
    {
        public enum BillingStates
        {
            Billed = 'B',
            Nulled = 'N',
            Paid = 'P',
            Quoted = 'Q',
            Converted = 'C'
        }

        public enum ExcelColumnsDef
        {
            TEXT = 1,
            DECIMAL = 2,
            INTEGER = 3,
            DATETIME = 4
        }
       

        public enum SequenceTypes
        {
            Invoices = 1,
            Sellers = 2,
            Customers = 3,
            Quotes = 4,
            Expenses = 5,
            WarehouseTransfers = 6,
            InventoryIncomes = 7,
            CustomersReturns = 8,
            SupplierReturns = 9,
            CustomerPayments = 10,
            ExpensesPayments = 11
        }
        public enum AppSections
        {
            Permissions = 1,
            CustomerRates = 2,
            Products = 3,
            CustomerPayments = 4,
            Currencies = 5,
            Taxes = 6,
            Invoices = 7,
            Quotes = 8,
            Customers = 9,
            Warehouses = 10,
            All = 11,
            Inventories=12,
            TRNControl=13,
            Expenses=14,
            BranchOffices=15,
            ExpensesPayments=16,
            Suppliers=17,
            Units=18,
            Users=19,
            PaymentTypes=20,
            CashRegisters=21,
            CashRegisterOpenings=22,
            CashRegisterOpeningsAmounts=23,
            IncomeMovements=24,
            CustomersReturns=25,
            SuppliersReturns=26,
            WarehouseTransfers=27,
            ProductUnits=28,
            Roles=29,
            Sections=30,
            Operations=31,
            Menu=32,
            Sellers=33,
            Zones=34,
            UserRoles=35,
            WarehouseMovements=36,
            DashBoard=37

        }
        public enum MovementTypes
        {
            IN = 1,
            OUT = 2
        }

        public enum PaymentTypes
        {
            CASH = 1,
            CHECK = 2,
            CREDITCARD = 3,
            BANKTRANSFER=4
        }
       public static Dictionary<AppSections, string> SectionsControllers = new Dictionary<AppSections, string>()
        {
            {AppSections.Permissions,"User,UserClaims,Role,RoleSection,Section,SectionOperation" },
            {AppSections.CustomerRates,"Customer,CustomerRate" },
            {AppSections.Products,"Product,ProductTax" },
            {AppSections.CustomerPayments,"Customer,CustomerPayment" },
            {AppSections.Currencies,"Currency" },
            {AppSections.Taxes,"Taxe" },
            {AppSections.Invoices,"Invoice,InvoiceDetail,TRNControl,Unit,UnitProductEquivalence,Seller,BranchOffice,Warehouse,CreditNote,Currency,Customer,Inventory,PaymentType" },
            {AppSections.Quotes,"Invoice,InvoiceDetail,Unit,UnitProductEquivalence,Seller,Currency,Customer" },
            {AppSections.Customers,"Customer,BranchOffice,Warehouse,TRNControl,Zone" },
            {AppSections.Warehouses,"BranchOffice,Warehouse" },
            {AppSections.All,"*" },
            {AppSections.Inventories,"Inventory,Product,BranchOffice,Warehouse,Supplier" },
            {AppSections.TRNControl,"TRNControl" },
            {AppSections.Expenses,"Supplier,Expense,Tax,ExpenseTax,Currency" },
            {AppSections.BranchOffices,"BranchOffice,Warehouse" },
            {AppSections.ExpensesPayments,"Supplier,BranchOffice,User,Currency,Tax" },
            {AppSections.Suppliers,"Supplier" },
            {AppSections.Units,"Unit" },
            {AppSections.Users,"User,BranchOffice,Warehouse,CashRegister" },
            {AppSections.PaymentTypes,"PaymentType" },
            {AppSections.CashRegisters,"CashRegister,BranchOffice" },
            {AppSections.CashRegisterOpenings,"CashRegister,User,CashRegisterOpening" },
            {AppSections.CashRegisterOpeningsAmounts,"CashRegister,User,CashRegisterOpening" },
            {AppSections.IncomeMovements,"Supplier,Product,Tax,User" },
            {AppSections.CustomersReturns,"Invoice,Product,InvoiceDetail,Customer" },
            {AppSections.SuppliersReturns,"Supplier,Expense,Tax,Currency" },
            {AppSections.WarehouseTransfers,"BranchOffice,Warehouse,User,Product,Unit" },
            {AppSections.ProductUnits,"Product,Unit," },
            {AppSections.Roles,"Role" },
            {AppSections.Sections,"Section" },
            {AppSections.Operations,"Operation" },
            {AppSections.Menu,"" },
            {AppSections.Sellers,"Seller,Zone,BranchOffice" },
            {AppSections.Zones,"" },
            {AppSections.UserRoles,"Users,Role,UserRole" },
            {AppSections.WarehouseMovements,"" },
            {AppSections.DashBoard,"" },
        };
        public enum Gender
        {
            Male = 'M',
            Female = 'F'
        }

        public enum Operations
        {
            READ = 1,
            ADD = 2,
            UPDATE = 3,
            DELETE = 4,
            READALL=5,
            READPAGED=6,
            ALL=7
        }
    }
}
