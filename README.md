# PointOfSalesV2
Basic Web ERP application for small to medium companies using .Net core and Angular. This project uses the akveo ngx-admin template (https://github.com/akveo/ngx-admin). Work in progress....

# Pre-Requisites
- .net core 3.1
- Angular 8.2.14
- Sql server
- nodejs 

# Installation
1- Create a new database /n
2- Modify the PointOfSalesV2.Api main connectionString (appSettings.json file)
3- Open in visual studio Package Manager Console
4- Set default project in PMC to PointOfSalesV2.EntityFramework
5- Apply migrations (update-database command)
6- Run the PointOfSalesV2.Api project
6.5- Launch the PointOfSalesV2.FrontEnd project (you can also open the ClientApp folder with VS code, open new terminal and set command "ng serve")
7- Default user is admin@admin.com with password Admin@123
8- After you launch the application you need to login and at least set one "Branch Office"
9- Go to "Auth" tab, Edit admin user, and set the branch office for that user (otherwise you'll get an error when billing :)

# First time configuration

