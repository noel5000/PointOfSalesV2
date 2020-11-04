# PointOfSalesV2
Basic Web ERP application for small to medium companies using .Net core and Angular. This project uses the akveo ngx-admin template (https://github.com/akveo/ngx-admin). Work in progress....

# Pre-Requisites
- .net core 3.1
- Angular 8.2.14
- Sql server
- nodejs 

# Installation
- 1- Create a new database
- 2- Modify the PointOfSalesV2.Api main connectionString (appSettings.json file)
- 3- Open in visual studio Package Manager Console
- 4- Set default project in PMC to PointOfSalesV2.EntityFramework
- 5- Apply migrations (update-database command)
- 6- Run the PointOfSalesV2.Api project
- 6.5- Launch the PointOfSalesV2.FrontEnd project (you can also open the ClientApp folder with VS code, open new terminal and set commands "npm install" and  "ng serve")
- 7- Default user is admin@admin.com with password Admin@123
- 8- After you launch the application you need to login and at least set one "Branch Office"
- 9- Go to "Auth" tab, Edit admin user, and set the branch office for that user (otherwise you'll get an error when billing :)

This project is intended to be hosted in IIS for both, API and Front End. So go to IIS manager, create both endpoints, publish each one to their respectives endpoints, validate a successful publish and start working.

# First time configuration
When you get the app working, the first thing to do is set the Configurations tab options, mostly in this order:
- Branch Office: Physical localities of the business. If no branch office exist, just create at least one
- Warehouses: Where physical products are stored. We need to create two, Main warehouse, and the returns (deffectives) one [with "DEF" code]
- Currencies: At least one is need (main currency)
- Suppliers
- Taxes
- Units: Measures definitions of products (it can be Units, Lb, Oz, Kg, ect
- TRN controls: Tax receipts numeration control
- Zones: Geographic grouping of customers and sellers
- Sellers
- Customers
- Products

After that, you only need to give the products input int Movements-> Inventory incomes, and you can start billing ;)

# Users roles
Users roles are predefined by default, no roles configuration is needed. Just assing roles to users to defined their scope of operations. For now, roles names are in spanish, they need to be translated (Work in progress)

# Internationalization

this project uses the standard i18n Angular library (ngx-translate). For entities, they save the data by the creation/edition user language, so, if you need a product with the name translated for differents languages, you need to set the language to the user, and then save/edit the product with that language (be sure to logout - login when you set the language to an user to be effectively applied). You can also edit with more that one user (different tabs) each of them with different language.
