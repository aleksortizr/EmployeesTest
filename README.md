# EmployeesTest
Recruiting Test for MAS

Uses the MAS employees API to implement factory method calculation 

CONTENT:

- Employees_API: API that searches and calculates employees salary.
- Employees_BusinessLayer: Implements the formulas and provides the factory Method
- Employees_DataAccess: Invokes the MAS API and returns the DTO
- Employess_Common: Defines the DTO classes
- Employees_MVC: MVC Web Application to handle the front end pages


INSTRUCTIONS:

1. The solutions executes both projects at startup: API and MVC
2. Execute the Employees_API project (already set as startup project) and copy the Swagger interface URL first part until port number
3. In Employees_MVC\Employees\appsettings.json set the Key WebApi-> Url with the URL copied in the previous step.
4. Launch the solution. 
