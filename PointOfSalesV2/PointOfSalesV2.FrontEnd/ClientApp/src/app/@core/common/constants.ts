import { AppSections } from './enums';

export const endpointUrl = 'https://localhost:44386/api/';
//export const endpointUrl = 'http://noeltest400-001-site6.ctempurl.com/api/';

export const endpointViewsUrl = 'https://localhost:44386/';
//export const endpointViewsUrl = 'http://noeltest400-001-site6.ctempurl.com/';

export const endpointControllers = {
    login: 'Login',
    products: 'product',
    logout: 'logout',
    languages: 'language',
    branchOffices: 'branchOffice',
    units: 'unit',
    taxes: 'tax',
    currencies: 'currency',
    zones: 'zone',
    trncontrol: 'trncontrol',
    warehoses: 'warehouse',
    sellers:'seller',
    suppliers:'supplier',
    customers:'customer',
    productTaxes:'productTax',
    users:'user',
    cashRegister:'cashRegister',
    expenses:'expense',
    expensePayment:'expensesPayment',
    schools:'school'
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