import { AppSections } from './enums';

export const endpointUrl = 'https://localhost:5001/api/';


export const endpointControllers = {
    login: 'Login',
    products: 'products',
    logout: 'logout',
    languages: 'language',
    branchOffices: 'branchOffice'
}

export const menuChildren = {
    core: [
        AppSections.BranchOffices,
        AppSections.Warehouses,
        AppSections.Currencies,
        AppSections.Suppliers,
        AppSections.Taxes,
        AppSections.Units,
        AppSections.TRNControl,
        AppSections.Zones,
        AppSections.Sellers,
        AppSections.Customers,
        AppSections.Products,
    ],
    cashRegister: [
        AppSections.CashRegisters,
        AppSections.CashRegisterOpenings
    ],
    billing: [
        AppSections.Quotes,
        AppSections.Invoices,
        AppSections.CustomerPayments
    ],
    expenses: [
        AppSections.Expenses,
        AppSections.ExpensesPayments
    ],
    reports: [
        AppSections.SalesReport,
        AppSections.AccountsReceivable,
        AppSections.IncomeReceipts,
        AppSections.Commisions,
        AppSections.Inventories,
        AppSections.ProductMovements,
        AppSections.DebstToPay,
        AppSections.PriceList,
        AppSections.CustomersList,
        AppSections.AccountState,
        AppSections.ResultState,
        AppSections.TaxesReport
    ],
    movements: [
        AppSections.InventoryIncomes,
        AppSections.WarehouseTransfers,
        AppSections.CustomersReturns,
        AppSections.SuppliersReturns
    ],
    auth: [
        AppSections.Users,
        AppSections.Roles
    ]
}