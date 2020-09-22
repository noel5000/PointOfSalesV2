using Microsoft.EntityFrameworkCore;
using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static PointOfSalesV2.Common.Enums;

namespace PointOfSalesV2.Repository.Helpers
{
    public class SequencesHelper
    {
        public static string CreateInvoiceControl(IDataRepositoryFactory dataRepositoryFactory)
        {
            try
            {
                var repo = dataRepositoryFactory.GetDataRepositories<SequenceControl>();
                string result = string.Empty;
                SequenceControl lastControl = repo.Get(x => x.AsNoTracking().Where(y => y.Active == true && y.Code == (short)SequenceTypes.Invoices));

                result = String.Format("{0}{1:00000}", lastControl.Code, (lastControl.NumericControl + 1));
                lastControl.NumericControl += 1;
                repo.Update(lastControl);
                return result;
            }
            catch
            {
                throw new Exception($"sequenceError_msg");
            }


        }

        internal static string CreateSellersControl(IDataRepositoryFactory dataRepositoryFactory)
        {
            try
            {
                var repo = dataRepositoryFactory.GetDataRepositories<SequenceControl>();
                string result = string.Empty;
                SequenceControl lastControl = repo.Get(x => x.AsNoTracking().Where(y => y.Active == true && y.Code == (short)SequenceTypes.Sellers));

                result = String.Format("{0}{1:00000}", lastControl.Code, (lastControl.NumericControl + 1));
                lastControl.NumericControl += 1;
                repo.Update(lastControl);
                return result;
            }
            catch
            {
                throw new Exception($"sequenceError_msg");
            }
        }

        public static string CreateCustomersControl(IDataRepositoryFactory dataRepositoryFactory)
        {
            try
            {
                var repo = dataRepositoryFactory.GetDataRepositories<SequenceControl>();
                string result = string.Empty;
                SequenceControl lastControl = repo.Get(x => x.AsNoTracking().Where(y => y.Active == true && y.Code == (short)SequenceTypes.Customers));

                result = String.Format("{0}{1:00000}", lastControl.Code, (lastControl.NumericControl + 1));
                lastControl.NumericControl += 1;
                repo.Update(lastControl);
                return result;
            }
            catch 
            {
                throw new Exception($"sequenceError_msg");
            }


        }

        public static string CreateQuotesControl(IDataRepositoryFactory dataRepositoryFactory)
        {
            try
            {
                var repo = dataRepositoryFactory.GetDataRepositories<SequenceControl>();
                string result = string.Empty;
                SequenceControl lastControl = repo.Get(x => x.AsNoTracking().Where(y => y.Active == true && y.Code == (short)SequenceTypes.Quotes));

                result = String.Format("{0}{1:00000}", lastControl.Code, (lastControl.NumericControl + 1));
                lastControl.NumericControl += 1;
                repo.Update(lastControl);
                return result;
            }
            catch 
            {
                throw new Exception($"sequenceError_msg");
            }


        }

        public static string CreateExpensesControl(IDataRepositoryFactory dataRepositoryFactory)
        {
            try
            {
                var repo = dataRepositoryFactory.GetDataRepositories<SequenceControl>();
                string result = string.Empty;
                SequenceControl lastControl = repo.Get(x => x.AsNoTracking().Where(y => y.Active == true && y.Code == (short)SequenceTypes.Expenses));
                result = String.Format("{0}{1:00000}", lastControl.Code, (lastControl.NumericControl + 1));
                lastControl.NumericControl += 1;
                repo.Update(lastControl);
                return result;
            }
            catch
            {
                throw new Exception($"sequenceError_msg");
            }


        }

        public static string CreateWarehouseTransfersControl(IDataRepositoryFactory dataRepositoryFactory)
        {
            try
            {
                var repo = dataRepositoryFactory.GetDataRepositories<SequenceControl>();
                string result = string.Empty;
                SequenceControl lastControl = repo.Get(x => x.AsNoTracking().Where(y => y.Active == true && y.Code == (short)SequenceTypes.WarehouseTransfers));
                result = String.Format("{0}{1:00000}", lastControl.Code, (lastControl.NumericControl + 1));
                lastControl.NumericControl += 1;
                repo.Update(lastControl);
                return result;
            }
            catch
            {
                throw new Exception($"sequenceError_msg");
            }



        }

        public static string CreateInventoryIncomesControl(IDataRepositoryFactory dataRepositoryFactory)
        {
            try
            {
                var repo = dataRepositoryFactory.GetDataRepositories<SequenceControl>();
                string result = string.Empty;
                SequenceControl lastControl = repo.Get(x => x.AsNoTracking().Where(y => y.Active == true && y.Code == (short)SequenceTypes.InventoryIncomes));
                result = String.Format("{0}{1:00000}", lastControl.Code, (lastControl.NumericControl + 1));
                lastControl.NumericControl += 1;
                repo.Update(lastControl);
                return result;
            }
            catch
            {
                throw new Exception($"sequenceError_msg");
            }



        }

        public static string CreateCustomersReturnsControl(IDataRepositoryFactory dataRepositoryFactory)
        {
            try
            {
                var repo = dataRepositoryFactory.GetDataRepositories<SequenceControl>();
                string result = string.Empty;
                SequenceControl lastControl = repo.Get(x => x.AsNoTracking().Where(y => y.Active == true && y.Code == (short)SequenceTypes.CustomersReturns));
                result = String.Format("{0}{1:00000}", lastControl.Code, (lastControl.NumericControl + 1));
                lastControl.NumericControl += 1;
                repo.Update(lastControl);
                return result;
            }
            catch 
            {
                throw new Exception($"sequenceError_msg");
            }



        }

        public static string CreateSupplierReturnsControl(IDataRepositoryFactory dataRepositoryFactory)
        {
            try
            {
                var repo = dataRepositoryFactory.GetDataRepositories<SequenceControl>();
                string result = string.Empty;
                SequenceControl lastControl = repo.Get(x => x.AsNoTracking().Where(y => y.Active == true && y.Code == (short)SequenceTypes.SupplierReturns));

                result = String.Format("{0}{1:00000}", lastControl.Code, (lastControl.NumericControl + 1));
                lastControl.NumericControl += 1;
                repo.Update(lastControl);
                return result;
            }
            catch 
            {
                throw new Exception($"sequenceError_msg");
            }



        }

        public static string CreatePaymentControl(IDataRepositoryFactory dataRepositoryFactory)
        {
            try
            {
                var repo = dataRepositoryFactory.GetDataRepositories<SequenceControl>();
                string result = string.Empty;
                SequenceControl lastControl = repo.Get(x => x.AsNoTracking().Where(y => y.Active == true && y.Code == (short)SequenceTypes.CustomerPayments));
                result = String.Format("{0}{1:00000}", lastControl.Code, (lastControl.NumericControl + 1));
                lastControl.NumericControl += 1;
                repo.Update(lastControl);
                return result;
            }
            catch
            {
                throw new Exception($"sequenceError_msg");
            }


        }

        public static string CreateExpensePaymentControl(IDataRepositoryFactory dataRepositoryFactory)
        {
            try
            {
                var repo = dataRepositoryFactory.GetDataRepositories<SequenceControl>();
                string result = string.Empty;
                SequenceControl lastControl = repo.Get(x => x.AsNoTracking().Where(y => y.Active == true && y.Code == (short)SequenceTypes.ExpensePayments));
                result = String.Format("{0}{1:00000}", lastControl.Code, (lastControl.NumericControl + 1));
                lastControl.NumericControl += 1;
                repo.Update(lastControl);
                return result;
            }
            catch
            {
                throw new Exception($"sequenceError_msg");
            }


        }

        public static string CreateSequenceControl(IDataRepositoryFactory dataRepositoryFactory, SequenceTypes sequenceTypes)
        {
            try
            {
                var repo = dataRepositoryFactory.GetDataRepositories<SequenceControl>();
                string result = string.Empty;
                SequenceControl lastControl = repo.Get(x => x.AsNoTracking().Where(y => y.Active == true && y.Code == (short)sequenceTypes));
                result = String.Format("{0}{1:00000}", lastControl.CodeName, (lastControl.NumericControl + 1));
                lastControl.NumericControl += 1;
                repo.Update(lastControl);
                return result;
            }
            catch 
            {
                throw new Exception($"sequenceError_msg");
            }


        }
    }
}
