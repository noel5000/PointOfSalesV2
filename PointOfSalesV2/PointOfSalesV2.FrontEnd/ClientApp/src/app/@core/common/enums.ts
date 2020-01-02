export enum BillingStates {
    Billed = 'B',
    Nulled = 'N',
    Paid = 'P',
    Quoted = 'Q',
    Converted = 'C'
}

export enum ExcelColumnsDef {
    TEXT = 1,
    DECIMAL = 2,
    INTEGER = 3,
    DATETIME = 4
}



export enum AppSections {
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
    Inventories = 12,
    TRNControl = 13,
    Expenses = 14,
    BranchOffices = 15,
    ExpensesPayments = 16,
    Suppliers = 17,
    Units = 18,
    Users = 19,
    PaymentTypes = 20,
    CashRegisters = 21,
    CashRegisterOpenings = 22,
    CashRegisterOpeningsAmounts = 23,
    IncomeMovements = 24,
    CustomersReturns = 25,
    SuppliersReturns = 26,
    WarehouseTransfers = 27,
    ProductUnits = 28,
    Roles = 29,
    Sections = 30,
    Operations = 31,
    Menu = 32,
    Sellers = 33,
    Zones = 34,
    UserRoles = 35,
    WarehouseMovements = 36,
    DashBoard = 37
}
export enum MovementTypes {
    IN = 1,
    OUT = 2
}

export enum PaymentTypes {
    CASH = 1,
    CHECK = 2,
    CREDITCARD = 3,
    BANKTRANSFER = 4
}

export enum Gender {
    Male = 'M',
    Female = 'F'
}

export enum Operations {
    READ = 1,
    ADD = 2,
    UPDATE = 3,
    DELETE = 4,
    READALL = 5,
    READPAGED = 6,
    ALL = 7
}