import { Component } from '@angular/core';

import { MENU_ITEMS } from './pages-menu';
import { NbMenuItem } from '@nebular/theme';
import { LanguageService } from './../@core/services/translateService';
import { SecurityService } from '../@core/services/securityService';
import { menuChildren } from '../@core/common/constants';
import { User } from './../@core/data/users';
import { AppSections } from '../@core/common/enums';

@Component({
  selector: 'ngx-pages',
  styleUrls: ['pages.component.scss'],
  template: `
    <ngx-one-column-layout>
      <nb-menu [items]="menu"></nb-menu>
      <router-outlet></router-outlet>
    </ngx-one-column-layout>
  `,
})
export class PagesComponent {
  constructor(private lang: LanguageService, private securityService: SecurityService) { }

  menu: NbMenuItem[] = [
    {
      title: this.lang.getValueByKey('start_menu'),
      icon: 'home-outline',
      link: '/pages/dashboard',
      home: true,
      hidden: false
    },
    {
      title: this.lang.getValueByKey('user_menu'),
      icon: 'person-outline',
      hidden: false,
      children: [
        {
          title: this.lang.getValueByKey('changePass_menu'),
          link: '/auth/changePass',
          hidden: false
        },
        {
          title: this.lang.getValueByKey('login_menu'),
          link: '/auth/login',
          hidden: false
        },
        {
          title: this.lang.getValueByKey('logOut_btn'),
          link: '/auth/logOut',
          hidden: false
        },
        {
          title: this.lang.getValueByKey('resetPass_menu'),
          link: '/auth/reset-password',
          hidden: false
        },
      ],
    },
    {
      title: this.lang.getValueByKey('core_menu'),
      icon: 'settings-2-outline',
      hidden: !this.securityService.validateMenuChildren(menuChildren.core),
      children: [
        {
          title: this.lang.getValueByKey('branchOffice_menu'),
          link: 'branchoffice',
          hidden: !this.securityService.isUserValidInMenu(AppSections.BranchOffices)
        },
        {
          title: this.lang.getValueByKey('warehouse_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.Warehouses)
        },
        {
          title: this.lang.getValueByKey('currencies_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.Currencies)
        },
        {
          title: this.lang.getValueByKey('suppliers_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.Suppliers)
        },
        {
          title: this.lang.getValueByKey('taxes_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.Taxes)
        },
        {
          title: this.lang.getValueByKey('units_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.Units)
        },
        {
          title: this.lang.getValueByKey('TRNControl_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.TRNControl)
        },
        {
          title: this.lang.getValueByKey('zones_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.Zones)
        },
        {
          title: this.lang.getValueByKey('sellers_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.Sellers)
        },
        {
          title: this.lang.getValueByKey('customers_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.Customers)
        },
        {
          title: this.lang.getValueByKey('products_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.Products)
        },
      ],
    },
    {
      title: this.lang.getValueByKey('cashRegister_menu'),
      icon: 'printer-outline',
      hidden: !this.securityService.validateMenuChildren(menuChildren.cashRegister),
      children: [
        {
          title: this.lang.getValueByKey('cashRegisterManteinance_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.CashRegisters)
        },
        {
          title: this.lang.getValueByKey('cashROpenClose_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.CashRegisterOpenings)
        }
      ],
    },
    {
      title: this.lang.getValueByKey('billing_menu'),
      icon: 'shopping-cart-outline',
      hidden: !this.securityService.validateMenuChildren(menuChildren.billing),
      children: [
        {
          title: this.lang.getValueByKey('quotes_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.Quotes)
        },
        {
          title: this.lang.getValueByKey('invoices_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.Invoices)
        },
        {
          title: this.lang.getValueByKey('customerPayment_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.CustomerPayments)
        }
      ],
    },
    {
      title: this.lang.getValueByKey('expenses_menu'),
      icon: 'shopping-bag-outline',
      hidden: !this.securityService.validateMenuChildren(menuChildren.expenses),
      children: [
        {
          title: this.lang.getValueByKey('expensesRegister_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.Expenses)
        },
        {
          title: this.lang.getValueByKey('expensesPayment_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.ExpensesPayments)
        }
      ],
    },
    {
      title: this.lang.getValueByKey('reports_menu'),
      icon: 'file-text-outline',
      hidden: !this.securityService.validateMenuChildren(menuChildren.reports),
      children: [
        {
          title: this.lang.getValueByKey('sales_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.SalesReport)
        },
        {
          title: this.lang.getValueByKey('accountsReceivable_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.AccountsReceivable)
        },
        {
          title: this.lang.getValueByKey('incomeReceipts_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.IncomeReceipts)
        },
        {
          title: this.lang.getValueByKey('commissions_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.Commisions)
        },
        {
          title: this.lang.getValueByKey('inventory_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.Inventories)
        },
        {
          title: this.lang.getValueByKey('productsMovements_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.ProductMovements)
        },
        {
          title: this.lang.getValueByKey('debtsToPay_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.DebstToPay)
        },
        {
          title: this.lang.getValueByKey('pricesList_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.PriceList)
        },
        {
          title: this.lang.getValueByKey('customersList_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.CustomersList)
        },
        {
          title: this.lang.getValueByKey('accountState_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.AccountState)
        },
        {
          title: this.lang.getValueByKey('resultState_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.ResultState)
        },
        {
          title: this.lang.getValueByKey('taxesReport_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.TaxesReport)
        }
      ],
    },
    {
      title: this.lang.getValueByKey('movements_menu'),
      icon: 'car-outline',
      hidden: !this.securityService.validateMenuChildren(menuChildren.movements),
      children: [
        {
          title: this.lang.getValueByKey('inventoryIn_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.InventoryIncomes)
        },
        {
          title: this.lang.getValueByKey('warehouseTransfers_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.WarehouseTransfers)
        },
        {
          title: this.lang.getValueByKey('customersReturns_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.CustomersReturns)
        },
        {
          title: this.lang.getValueByKey('suppliersReturns_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.SuppliersReturns)
        }
      ],
    },
    {
      title: this.lang.getValueByKey('auth_menu'),
      icon: 'lock-outline',
      hidden: !this.securityService.validateMenuChildren(menuChildren.auth),
      children: [
        {
          title: this.lang.getValueByKey('users_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.Users)
        },
        {
          title: this.lang.getValueByKey('roles_menu'),
          link: '',
          hidden: !this.securityService.isUserValidInMenu(AppSections.Roles)
        }
      ],
    },
  ];
}
